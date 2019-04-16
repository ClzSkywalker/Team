﻿using System.Collections.Generic;
using System.Linq;
using Team.Infrastructure.DbContext;
using Team.Infrastructure.IRepositories;
using Team.Model.Model;

namespace Team.Infrastructure.Repositories
{
    public class RunRepository : IRunRepository
    {
        #region Initial

        private readonly MyContext _myContext;

        public RunRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        #endregion

        /// <summary>
        /// 记录跑步
        /// </summary>
        /// <param name="userId">用户 Id</param>
        /// <param name="run"></param>
        public void FreeRecord(int userId, Run run)
        {
            run.UserId = userId;
            _myContext.Add(run);
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <param name="userId">用户 Id</param>
        /// <returns></returns>
        public IEnumerable<Run> FreeSearch(int userId)
        {
            return _myContext.Runs.Where(x => x.UserId == userId).ToList();
        }

        /// <summary>
        /// 达标记录
        /// </summary>
        /// <param name="userId">用户 Id</param>
        /// <returns></returns>
        public IEnumerable<Run> ExerciseList(int userId)
        {
            return _myContext.Runs.Where(x =>
                x.UserId == userId && x.SportFreeModel == SportFreeModel.Runing && x.Distance >= 4000).ToList();
        }
    }
}