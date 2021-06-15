using AutoMapper;
using AutoMapper.QueryableExtensions;
using BeCoreApp.Application.Interfaces;
using BeCoreApp.Application.ViewModels.Location;
using BeCoreApp.Application.ViewModels.System;
using BeCoreApp.Data.Entities;
using BeCoreApp.Data.Enums;
using BeCoreApp.Data.IRepositories;
using BeCoreApp.Infrastructure.Interfaces;
using BeCoreApp.Utilities.Dtos;
using BeCoreApp.Utilities.Extensions;
using BeCoreApp.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BeCoreApp.Application.Implementation
{
    public class TransactionService : ITransactionService
    {
        private ITransactionRepository _transactionRepository;
        private IUnitOfWork _unitOfWork;

        public TransactionService(ITransactionRepository transactionRepository, IUnitOfWork unitOfWork)
        {
            _transactionRepository = transactionRepository;
            _unitOfWork = unitOfWork;
        }

        public PagedResult<TransactionViewModel> GetAllPaging(string keyword, string appUserId, int pageIndex, int pageSize)
        {
            var query = _transactionRepository.FindAll(x => x.AppUser);

            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.AppUser.FullName.Contains(keyword) || x.TransactionHas.Contains(keyword)
                || x.AddressTo.Contains(keyword));

            if (!string.IsNullOrWhiteSpace(appUserId))
                query = query.Where(x => x.AppUserId.ToString() == appUserId);

            var totalRow = query.Count();
            var data = query.OrderByDescending(x => x.Id)
                .Skip((pageIndex - 1) * pageSize).Take(pageSize)
                .Select(x => new TransactionViewModel()
                {
                    Id = x.Id,
                    AddressTo = x.AddressTo,
                    Amount = x.Amount,
                    StrAmount = x.Amount.ToString(),
                    AppUserId = x.AppUserId,
                    AppUserName = x.AppUser.UserName,
                    DateCreated = x.DateCreated,
                    TransactionHas = x.TransactionHas,
                    Type = x.Type,
                    TypeName = x.Type.GetDescription()
                }).ToList();

            return new PagedResult<TransactionViewModel>()
            {
                CurrentPage = pageIndex,
                PageSize = pageSize,
                Results = data,
                RowCount = totalRow
            };
        }

        public IQueryable<CustomerTransaction> GetUserAmountByTransactionType(string appUserId)
        {
            var query = _transactionRepository
                .FindAll(x => x.AppUserId == new Guid(appUserId));

            return query;
        }

        public int CountByType(string appUserId, TransactionType type)
        {
            var countItem = _transactionRepository
                .FindAll(x => x.AppUserId == new Guid(appUserId) && x.Type == type).Count();

            return countItem;
        }

        public int CountByType(TransactionType type)
        {
            var countItem = _transactionRepository.FindAll(x => x.Type == type).Count();
            return countItem;
        }


        public void Add(TransactionViewModel model)
        {
            var transaction = new CustomerTransaction()
            {
                AddressTo = model.AddressTo,
                Amount = model.Amount,
                AppUserId = model.AppUserId,
                DateCreated = model.DateCreated,
                TransactionHas = model.TransactionHas,
                Type = model.Type,
            };

            _transactionRepository.Add(transaction);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
