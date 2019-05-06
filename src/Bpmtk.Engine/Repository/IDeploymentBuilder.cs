﻿using System;
using System.Threading.Tasks;
using Bpmtk.Engine.Models;

namespace Bpmtk.Engine.Repository
{
    public interface IDeploymentBuilder
    {
        IDeploymentBuilder SetName(string name);

        IDeploymentBuilder SetMemo(string memo);

        IDeploymentBuilder SetCategory(string category);

        IDeploymentBuilder SetBpmnModel(byte[] modelData);

        IDeploymentBuilder SetPackage(Package package);

        IDeployment Build();

        Task<IDeployment> BuildAsync();
    }
}
