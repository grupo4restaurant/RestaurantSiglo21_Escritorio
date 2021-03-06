﻿using Siglo21Desktop.Entities;
using Siglo21Desktop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Siglo21Desktop.Dao
{
    class DominioDAO
    {

        HttpClient Client { get; set; }

        public DominioDAO()
        {
            this.Client = new HttpClient();
        }

        public async Task<HttpResponseMessage> Save(Domino obj)
        {
            string ruta = CommonEnums.CrudPath.DominioCrud;
            var response = await Client.PutAsJsonAsync(ruta, obj);

            return response;
        }

        public async Task<HttpResponseMessage> Update(Domino obj)
        {
            string ruta = CommonEnums.CrudPath.DominioCrud;
            var response = await Client.PostAsJsonAsync(ruta, obj);

            return response;
        }

        public async Task<HttpResponseMessage> Delete(int id)
        {

            string ruta = CommonEnums.CrudPath.DominioCrud;
            HttpResponseMessage response = await Client.DeleteAsync(ruta + id);

            return response;
        }

        public async Task<List<Domino>> GetAllByDomValDom(string dom_val_dom)
        {
            string ruta = CommonEnums.ListadoPath.DominioPorDomValDom + dom_val_dom;

            HttpResponseMessage response = await Client.GetAsync(ruta);

            if (response.IsSuccessStatusCode)
            {

                var item = (await response.Content.ReadAsAsync<IEnumerable<Domino>>()).ToList();
                return item;
            }

            return null;

        }

    }
}
