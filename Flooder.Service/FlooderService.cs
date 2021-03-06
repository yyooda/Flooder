﻿using System.ServiceProcess;

namespace Flooder.Service
{
    public partial class FlooderService : ServiceBase
    {
        private readonly IFlooderService _service;

        public FlooderService()
        {
            InitializeComponent();
            _service = ServiceFactory.Create<DefaultService>();
        }

        protected override void OnStart(string[] args)
        {
            _service.Start();
        }

        protected override void OnStop()
        {
            _service.Stop();
        }
    }
}
