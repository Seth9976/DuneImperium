using System;
using dwd.core.logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.iap.store
{
	// Token: 0x02000016 RID: 22
	public class IAPStoreFactory : MonoBehaviour
	{
		// Token: 0x06000126 RID: 294 RVA: 0x0000803C File Offset: 0x0000623C
		// Note: this type is marked as 'beforefieldinit'.
		static IAPStoreFactory()
		{
			Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("InAppPurchasing.dll", "dwd.iap.store", "IAPStoreFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr);
			IAPStoreFactory.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, "data");
			IAPStoreFactory.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_IAPStoreModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663557);
			IAPStoreFactory.NativeMethodInfoPtr_get_DataList_Public_get_IAPStoreModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663558);
			IAPStoreFactory.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663559);
			IAPStoreFactory.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663560);
			IAPStoreFactory.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663561);
			IAPStoreFactory.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663562);
			IAPStoreFactory.NativeMethodInfoPtr_Reinitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663563);
			IAPStoreFactory.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663564);
			IAPStoreFactory.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663565);
			IAPStoreFactory.NativeMethodInfoPtr_getProductProvider_Private_IIAPProductProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663566);
			IAPStoreFactory.NativeMethodInfoPtr_handleDisconnect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663567);
			IAPStoreFactory.NativeMethodInfoPtr_getEditorLogger_Protected_Virtual_New_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663568);
			IAPStoreFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663569);
			IAPStoreFactory.NativeMethodInfoPtr__Initialize_b__12_0_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr, 100663570);
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00008198 File Offset: 0x00006398
		public unsafe virtual IAPStoreModel Data
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201144, XrefRangeEnd = 1201145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_IAPStoreModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr3) : null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000081D8 File Offset: 0x000063D8
		public unsafe IAPStoreModel DataList
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201145, XrefRangeEnd = 1201146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_get_DataList_Public_get_IAPStoreModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr3) : null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00008218 File Offset: 0x00006418
		public unsafe virtual bool Initialized
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1201150, RefRangeEnd = 1201152, XrefRangeStart = 1201146, XrefRangeEnd = 1201150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00008254 File Offset: 0x00006454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201152, XrefRangeEnd = 1201164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008288 File Offset: 0x00006488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201164, XrefRangeEnd = 1201176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000082BC File Offset: 0x000064BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201176, XrefRangeEnd = 1201181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Request()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000082F0 File Offset: 0x000064F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201181, XrefRangeEnd = 1201182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_Reinitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00008324 File Offset: 0x00006524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00008358 File Offset: 0x00006558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1201213, RefRangeEnd = 1201215, XrefRangeStart = 1201182, XrefRangeEnd = 1201213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000838C File Offset: 0x0000658C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201215, XrefRangeEnd = 1201218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IIAPProductProvider getProductProvider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_getProductProvider_Private_IIAPProductProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IIAPProductProvider>(intPtr3) : null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000083CC File Offset: 0x000065CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201218, XrefRangeEnd = 1201225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleDisconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr_handleDisconnect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00008400 File Offset: 0x00006600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201225, XrefRangeEnd = 1201229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual dwd.core.logging.ILogger getEditorLogger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAPStoreFactory.NativeMethodInfoPtr_getEditorLogger_Protected_Virtual_New_ILogger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<dwd.core.logging.ILogger>(intPtr3) : null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000844C File Offset: 0x0000664C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAPStoreFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAPStoreFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00008488 File Offset: 0x00006688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201229, XrefRangeEnd = 1201235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__12_0(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAPStoreFactory.NativeMethodInfoPtr__Initialize_b__12_0_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000027C5 File Offset: 0x000009C5
		public IAPStoreFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000084CC File Offset: 0x000066CC
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000027CE File Offset: 0x000009CE
		public unsafe IAPStoreModel data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreFactory.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAPStoreModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IAPStoreFactory.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_IAPStoreModel_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_DataList_Public_get_IAPStoreModel_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_Reinitialize_Public_Void_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_getProductProvider_Private_IIAPProductProvider_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_handleDisconnect_Private_Void_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_getEditorLogger_Protected_Virtual_New_ILogger_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__12_0_Private_Void_Exception_0;
	}
}
