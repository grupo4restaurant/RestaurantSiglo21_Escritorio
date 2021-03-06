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
    class DetalleOrdenCompraDAO
    {

        HttpClient Client { get; set; }

        public DetalleOrdenCompraDAO()
        {
            this.Client = new HttpClient();
        }

        public async Task<HttpResponseMessage> Save(DetalleOrdenCompra obj)
        {
            string ruta = CommonEnums.CrudPath.DetalleOrdenCompraCrud;
            var response = await Client.PutAsJsonAsync(ruta, obj);

            return response;
        }

        public async Task<HttpResponseMessage> Update(DetalleOrdenCompra obj)
        {
            string ruta = CommonEnums.CrudPath.DetalleOrdenCompraCrud;
            var response = await Client.PostAsJsonAsync(ruta, obj);

            return response;
        }

        public async Task<HttpResponseMessage> Delete(int id)
        {

            string ruta = CommonEnums.CrudPath.DetalleOrdenCompraCrud;
            HttpResponseMessage response = await Client.DeleteAsync(ruta + id);

            return response;
        }

        public async Task<DetalleOrdenCompra> GetById(int id)
        {
            string ruta = CommonEnums.CrudPath.DetalleOrdenCompraCrud + id;

            HttpResponseMessage response = await Client.GetAsync(ruta);

            if (response.IsSuccessStatusCode)
            {

                var item = (await response.Content.ReadAsAsync<IEnumerable<DetalleOrdenCompra>>()).FirstOrDefault();
                return item;
            }

            return null;

        }

    }
}
