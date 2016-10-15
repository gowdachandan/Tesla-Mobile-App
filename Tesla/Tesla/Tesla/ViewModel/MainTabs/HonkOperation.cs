﻿using Exrin.Abstraction;
using Exrin.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tesla.Definition.ViewLocator;
using TeslaDefinition;
using TeslaDefinition.Enums;
using TeslaDefinition.Interfaces.Model;

namespace Tesla.ViewModel.MainTabs
{
    public class HonkOperation : IOperation
    {
        IControlModel _model = null;
        
        public HonkOperation(IControlModel model)
        {
            _model = model;
        }

        public bool ChainedRollback { get; private set; } = false;

        public Func<IList<IResult>, object, CancellationToken, Task> Function
        {
            get
            {
                return async (result, parameter, token) =>
                {
                    await _model.IssueCommand(CommandType.Honk);
                    result.Add(new Result() { ResultAction = ResultType.Navigation, Arguments = new NavigationArgs() { Key = Definition.ViewLocator.Control.ControlTwo, StackType = Stacks.Control } });
                };
            }
        }

        public Func<Task> Rollback { get { return null; } }
    }
}