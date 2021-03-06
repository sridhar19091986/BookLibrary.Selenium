﻿using Unity;

namespace BookLibrary.Selenium.Base
{
    public static class UnityContainerFactory
    {
        private static IUnityContainer _unityContainer;
        
        static UnityContainerFactory()
        {
            _unityContainer = new UnityContainer();
        }

        public static IUnityContainer GetContainer()
        {
            return _unityContainer;
        }
    }
}