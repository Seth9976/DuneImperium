using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000224 RID: 548
	public sealed class DefaultProxySectionInternal : Object
	{
		// Token: 0x060024B3 RID: 9395 RVA: 0x000A91FC File Offset: 0x000A73FC
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultProxySectionInternal()
		{
			Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "DefaultProxySectionInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr);
			DefaultProxySectionInternal.NativeFieldInfoPtr_webProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, "webProxy");
			DefaultProxySectionInternal.NativeFieldInfoPtr_classSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, "classSyncObject");
			DefaultProxySectionInternal.NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100668742);
			DefaultProxySectionInternal.NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100668743);
			DefaultProxySectionInternal.NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100668744);
			DefaultProxySectionInternal.NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100668745);
			DefaultProxySectionInternal.NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100668746);
			DefaultProxySectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr, 100668747);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000A92CC File Offset: 0x000A74CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487048, XrefRangeEnd = 487049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy GetDefaultProxy_UsingOldMonoCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x000A9300 File Offset: 0x000A7500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy GetSystemWebProxy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000A9334 File Offset: 0x000A7534
		public unsafe static Object ClassSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487049, XrefRangeEnd = 487058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x000A9368 File Offset: 0x000A7568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 487077, RefRangeEnd = 487078, XrefRangeStart = 487058, XrefRangeEnd = 487077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DefaultProxySectionInternal GetSection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultProxySectionInternal>(intPtr3) : null;
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x000A939C File Offset: 0x000A759C
		public unsafe IWebProxy WebProxy
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x000A93DC File Offset: 0x000A75DC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultProxySectionInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultProxySectionInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultProxySectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x0000FF76 File Offset: 0x0000E176
		public DefaultProxySectionInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x000A9418 File Offset: 0x000A7618
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x0000FF7F File Offset: 0x0000E17F
		public unsafe IWebProxy webProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultProxySectionInternal.NativeFieldInfoPtr_webProxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultProxySectionInternal.NativeFieldInfoPtr_webProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x000A9448 File Offset: 0x000A7648
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x0000FF9E File Offset: 0x0000E19E
		public unsafe static Object classSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultProxySectionInternal.NativeFieldInfoPtr_classSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultProxySectionInternal.NativeFieldInfoPtr_classSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeFieldInfoPtr_webProxy;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeFieldInfoPtr_classSyncObject;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultProxy_UsingOldMonoCode_Private_Static_IWebProxy_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemWebProxy_Private_Static_IWebProxy_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_get_ClassSyncObject_Internal_Static_get_Object_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_GetSection_Internal_Static_DefaultProxySectionInternal_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_get_WebProxy_Internal_get_IWebProxy_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
