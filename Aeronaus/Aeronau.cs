﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaus
{
    class Aeronau
    {
        private String model;
        private String fabricant;
        private int capacitat;
        private int x;
        private int y;
        private String matricula;
        private Boolean motorEnces = false;
        private int velocitat = 0;
        private int alcada = 0;
        private int rumb;
        private Boolean aparcat = false;
        private Boolean trenAterratgeDesplegat = true;
        private Action<object, EventArgs> introduirModel_TextChanged;
        private Action<object, EventArgs> introduirFabricant_TextChanged;
        private Action<object, EventArgs> introduirCapacitat_TextChanged;
        private object introduirMatricula_TextChanged;

        public Aeronau(String model, String fabricant, int capacitat, int X, int Y, String matricula)
        {
            this.model = model;
            this.fabricant = fabricant;
            this.capacitat = capacitat;
            this.x = X;
            this.y = Y;
            this.matricula = matricula;
        }

        public Aeronau(Action<object, EventArgs> introduirModel_TextChanged, Action<object, EventArgs> introduirFabricant_TextChanged, Action<object, EventArgs> introduirCapacitat_TextChanged, int x, int y, object introduirMatricula_TextChanged)
        {
            this.introduirModel_TextChanged = introduirModel_TextChanged;
            this.introduirFabricant_TextChanged = introduirFabricant_TextChanged;
            this.introduirCapacitat_TextChanged = introduirCapacitat_TextChanged;
            this.x = x;
            this.y = y;
            this.introduirMatricula_TextChanged = introduirMatricula_TextChanged;
        }


        //Setters

        public void setMotorEnces(Boolean estat)
        {
            this.motorEnces = estat;
        }

        public void setVelocitat(int velocitat)
        {
            this.velocitat = velocitat;
        }

        public void setAlcada(int alcada)
        {
            this.alcada = alcada;
        }

        public void setAparcat(Boolean aparcat)
        {
            this.aparcat = aparcat;
        }

        public void setRumb(int rumb)
        {
            this.rumb = rumb;
        }

        public void setTrenAterratgeDesplegat(Boolean trenAterratge)
        {
            this.trenAterratgeDesplegat = trenAterratge;
        }

        public void setXY(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        //Getters

        public String getModel()
        {
            return this.model;
        }

        public String getFabricant()
        {
            return this.fabricant;
        }

        public int getCapacitat()
        {
            return this.capacitat;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public String getMatricula()
        {
            return this.matricula;
        }

        public Boolean getMotorEnces()
        {
            return this.motorEnces;
        }
        public int getVelocitat()
        {
            return this.velocitat;
        }

        public int getAlcada()
        {
            return this.alcada;
        }

        public Boolean getAparcat()
        {
            return this.aparcat;
        }

        public int getRumb()
        {
            return this.rumb;
        }

        public Boolean getTrenAterratgeDesplegat()
        {
            return this.trenAterratgeDesplegat;
        }
    }
}
