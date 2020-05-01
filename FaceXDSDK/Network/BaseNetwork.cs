﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FaceXDSDK.Network
{
    public class BaseNetwork
    {
        public class Delegate
        {
            public delegate void OnConnect(string guid);
            public delegate void OnReceiveData(string guid, ArraySegment<byte> buffer, int size);
            public delegate void OnDisconnect(string guid);
        }
        public BaseNetwork() {

        }
        public Delegate.OnConnect onConnect { get; set; }
        public Delegate.OnReceiveData OnReceiveData { get; set; }
        public Delegate.OnDisconnect OnDisconnect { get; set; }

        public bool IsRunning { get; set; }
        
        public virtual void Start(string listenUrl)
        {
            this.IsRunning = true;
        }

        public virtual void Stop()
        {
            this.IsRunning = false;
        }

        public virtual async void SendDataAsync(string guid, ArraySegment<byte> buffer, int size)
        {
            await Task.Run(() =>
            {

            });
        }


        /// <summary>
        /// Key: User UUID String
        /// </summary>
        public Dictionary<string, Client> ClientContainer {
            get
            {
                return clientContainer;
            }
            set
            {
                ClientContainer = value;
            }
        }
        private Dictionary<string, Client> clientContainer = new Dictionary<string, Client>();
    }
}
