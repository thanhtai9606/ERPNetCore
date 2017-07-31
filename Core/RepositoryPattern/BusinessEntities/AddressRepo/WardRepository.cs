﻿
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.BusinessEntities.AddressRepo
{
    public class WardRepository : Repository<Ward>
    {
        public WardRepository(ERPDatabaseContext context) : base(context) { }

        public List<Ward> GetResult(string search, string sortOrder, int start, int length, List<string> columnFilters)
        {
            return FilterResult(search, columnFilters).Skip(start).Take(length).ToList();
        }

        public int Count(string search, List<string> columnFilters)
        {
            return FilterResult(search, columnFilters).Count();
        }

        private IQueryable<Ward> FilterResult(string search, List<string> columnFilters)
        {
            IQueryable<Ward> results = Context.Ward.ToList().AsQueryable();

            results = results.Where(p => (search == null
                || (p.WardName != null && p.WardName.ToLower().Contains(search.ToLower())
                || p.EnglishName != null && p.EnglishName.ToLower().Contains(search.ToLower())
                || p.WardId != null && p.WardId.ToLower().Contains(search.ToLower()) || p.Level != null && p.Level.ToLower().Contains(search.ToLower())
                || p.DistrictId != null && p.DistrictId.ToLower().Contains(search.ToLower()))
                || p.District.DistrictName != null && p.District.DistrictName.ToLower().Contains(search.ToLower()))
                && (columnFilters[0] == null || (p.WardId != null && p.WardId.ToLower().Contains(columnFilters[0].ToLower())))
                && (columnFilters[1] == null || (p.WardName != null && p.WardName.ToLower().Contains(columnFilters[1].ToLower())))
                && (columnFilters[2] == null || (p.EnglishName != null && p.EnglishName.ToLower().Contains(columnFilters[2].ToLower())))
                && (columnFilters[3] == null || (p.Level != null && p.Level.ToLower().Contains(columnFilters[3].ToLower()))
                && (columnFilters[4] == null || (p.DistrictId != null && p.DistrictId.ToLower().Contains(columnFilters[4].ToLower())))
                && (columnFilters[5] == null || (p.District.DistrictName != null && p.District.DistrictName.ToLower().Contains(columnFilters[5].ToLower())))));

            return results;
        }

        #region
        /// <summary>  
        /// Sort by column with order method.   
        /// </summary>  
        /// <param name="order">Order parameter</param>  
        /// <param name="orderDir">Order direction parameter</param>  
        /// <param name="data">Data parameter</param>  
        /// <returns>Returns - Data</returns>  
        public List<Ward> SortByColumnWithOrder(string order, string orderDir, List<Ward> data)
        {
            // Initialization.   
            List<Ward> lst = new List<Ward>();
            try
            {
                // Sorting   
                switch (order)
                {
                    case "0":
                        // Setting.   
                        lst = orderDir.Equals("DESC", StringComparison.CurrentCultureIgnoreCase) ? data.OrderByDescending(p => p.WardId).ToList() : data.OrderBy(p => p.WardId).ToList();
                        break;
                    case "1":
                        // Setting.   
                        lst = orderDir.Equals("DESC", StringComparison.CurrentCultureIgnoreCase) ? data.OrderByDescending(p => p.WardName).ToList() : data.OrderBy(p => p.WardName).ToList();
                        break;
                    case "2":
                        // Setting.   
                        lst = orderDir.Equals("DESC", StringComparison.CurrentCultureIgnoreCase) ? data.OrderByDescending(p => p.EnglishName).ToList() : data.OrderBy(p => p.EnglishName).ToList();
                        break;
                    case "3":
                        // Setting.   
                        lst = orderDir.Equals("DESC", StringComparison.CurrentCultureIgnoreCase) ? data.OrderByDescending(p => p.Level).ToList() : data.OrderBy(p => p.Level).ToList();
                        break;
                    case "4":
                        // Setting.   
                        lst = orderDir.Equals("DESC", StringComparison.CurrentCultureIgnoreCase) ? data.OrderByDescending(p => p.DistrictId).ToList() : data.OrderBy(p => p.DistrictId).ToList();
                        break;
                    case "5":
                        // Setting.   
                        lst = orderDir.Equals("DESC", StringComparison.CurrentCultureIgnoreCase) ? data.OrderByDescending(p => p.District.DistrictName).ToList() : data.OrderBy(p => p.District.DistrictName).ToList();
                        break;
                    default:
                        // Setting.   
                        lst = orderDir.Equals("DESC", StringComparison.CurrentCultureIgnoreCase) ? data.OrderByDescending(p => p.WardId).ToList() : data.OrderBy(p => p.WardId).ToList();
                        break;
                }
            }
            catch (Exception ex)
            {
                // info.   
                Console.Write(ex);
            }
            // info.   
            return lst;
        }
        #endregion
    }
}