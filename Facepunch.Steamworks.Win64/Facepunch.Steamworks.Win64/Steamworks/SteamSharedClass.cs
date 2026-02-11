using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000CA RID: 202
	public class SteamSharedClass<T> : SteamClass
	{
		// Token: 0x06000CD5 RID: 3285 RVA: 0x00053E88 File Offset: 0x00052088
		// Note: this type is marked as 'beforefieldinit'.
		static SteamSharedClass()
		{
			Il2CppClassPointerStore<SteamSharedClass<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamSharedClass`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamSharedClass<T>>.NativeClassPtr);
			SteamSharedClass<T>.NativeFieldInfoPtr_InterfaceClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamSharedClass<T>>.NativeClassPtr, "InterfaceClient");
			SteamSharedClass<T>.NativeFieldInfoPtr_InterfaceServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamSharedClass<T>>.NativeClassPtr, "InterfaceServer");
			SteamSharedClass<T>.NativeMethodInfoPtr_get_Interface_Internal_Static_get_SteamInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamSharedClass<T>>.NativeClassPtr, 100666435);
			SteamSharedClass<T>.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamSharedClass<T>>.NativeClassPtr, 100666436);
			SteamSharedClass<T>.NativeMethodInfoPtr_SetInterface_Internal_Virtual_New_Void_Boolean_SteamInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamSharedClass<T>>.NativeClassPtr, 100666437);
			SteamSharedClass<T>.NativeMethodInfoPtr_DestroyInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamSharedClass<T>>.NativeClassPtr, 100666438);
			SteamSharedClass<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamSharedClass<T>>.NativeClassPtr, 100666439);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00053F80 File Offset: 0x00052180
		public unsafe static SteamInterface Interface
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 948188, RefRangeEnd = 948198, XrefRangeStart = 948184, XrefRangeEnd = 948188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamSharedClass<T>.NativeMethodInfoPtr_get_Interface_Internal_Static_get_SteamInterface_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SteamInterface>(intPtr3) : null;
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00053FB4 File Offset: 0x000521B4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamSharedClass<T>.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00054000 File Offset: 0x00052200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948198, XrefRangeEnd = 948204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInterface(bool server, SteamInterface iface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamSharedClass<T>.NativeMethodInfoPtr_SetInterface_Internal_Virtual_New_Void_Boolean_SteamInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0005405C File Offset: 0x0005225C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948204, XrefRangeEnd = 948210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamSharedClass<T>.NativeMethodInfoPtr_DestroyInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x000540A8 File Offset: 0x000522A8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamSharedClass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamSharedClass<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamSharedClass<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x000033A9 File Offset: 0x000015A9
		public SteamSharedClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x000540E4 File Offset: 0x000522E4
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x000033B2 File Offset: 0x000015B2
		public unsafe static SteamInterface InterfaceClient
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamSharedClass<T>.NativeFieldInfoPtr_InterfaceClient, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamInterface>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamSharedClass<T>.NativeFieldInfoPtr_InterfaceClient, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0005410C File Offset: 0x0005230C
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x000033C4 File Offset: 0x000015C4
		public unsafe static SteamInterface InterfaceServer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamSharedClass<T>.NativeFieldInfoPtr_InterfaceServer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamInterface>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamSharedClass<T>.NativeFieldInfoPtr_InterfaceServer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeFieldInfoPtr_InterfaceClient;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeFieldInfoPtr_InterfaceServer;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_get_Interface_Internal_Static_get_SteamInterface_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_SetInterface_Internal_Virtual_New_Void_Boolean_SteamInterface_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_DestroyInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
