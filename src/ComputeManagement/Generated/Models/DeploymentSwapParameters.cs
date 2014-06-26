// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Parameters supplied to the Swap Deployment operation.
    /// </summary>
    public partial class DeploymentSwapParameters
    {
        private string _productionDeployment;
        
        /// <summary>
        /// Optional. The optional name of the production deployment.
        /// </summary>
        public string ProductionDeployment
        {
            get { return this._productionDeployment; }
            set { this._productionDeployment = value; }
        }
        
        private string _sourceDeployment;
        
        /// <summary>
        /// Required. The name of the source deployment.
        /// </summary>
        public string SourceDeployment
        {
            get { return this._sourceDeployment; }
            set { this._sourceDeployment = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentSwapParameters class.
        /// </summary>
        public DeploymentSwapParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentSwapParameters class
        /// with required arguments.
        /// </summary>
        public DeploymentSwapParameters(string sourceDeployment)
            : this()
        {
            if (sourceDeployment == null)
            {
                throw new ArgumentNullException("sourceDeployment");
            }
            this.SourceDeployment = sourceDeployment;
        }
    }
}
