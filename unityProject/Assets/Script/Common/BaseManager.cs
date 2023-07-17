/******************************************************************************
* @file        BaseManager.cs
* @brief       ����������
* @version     1.0
* @author      qinlongxiang
* @date        2022.07.12
*
******************************************************************************/

namespace Zszjl.Common
{
    #region ��
    /// <summary>
    /// ����������
    /// </summary>
    /// <typeparam name="T">����������</typeparam>
    public abstract class BaseManager<T> : SingletonUnity<T>, IManager where T : BaseManager<T>, new()
    {
        #region ����
        protected void Awake()
        {
            DontDestroyOnLoad(this);
        }

        public abstract void Register();
        public abstract void Unregister();
        #endregion
    }
    #endregion
}
