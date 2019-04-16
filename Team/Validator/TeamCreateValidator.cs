﻿using FluentValidation;
using Team.Model.AutoMappers;
using Team.Model.Model;

namespace Team.Validator
{
    /// <summary>
    /// 队伍创建模板验证
    /// </summary>
    public class TeamCreateValidator:AbstractValidator<TeamCreateMap>
    {
        public TeamCreateValidator()
        {
            //运动项目
            RuleFor(x => x.Sport)
                .NotEmpty().WithName("运动项目").WithMessage("{PropertyName} 不可为空")
                .IsInEnum();

            //约定时间
            RuleFor(x => x.AgreedTime)
                .NotEmpty().WithName("约定时间").WithMessage("{PropertyName} 不可为空");

            //相约总人数
            RuleFor(x => x.AllCount)
                .NotEmpty().WithName("相约总人数").WithMessage("{PropertyName} 不可为空");

            RuleFor(x => x.Note)
                .NotEmpty().WithName("备注信息").WithMessage("{PropertyName} 不可为空")
                .MaximumLength(200).WithMessage("{PropertyName} 最大长度不可超过 {MaxLength}");
        }
    }
}