﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Builder.VehicleBuilder
{
    public interface IVehicleBuilder
    {
        void InstallWheels();
        void PaintVehicle();
        void BuildEngine();
        void PremierePackage();
        Vehicle GetVehicle();

    }
}
