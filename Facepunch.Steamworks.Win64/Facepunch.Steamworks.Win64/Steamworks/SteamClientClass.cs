using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000CB RID: 203
	public class SteamClientClass<T> : SteamClass
	{
		// Token: 0x06000CE0 RID: 3296 RVA: 0x00054134 File Offset: 0x00052334
		// Note: this type is marked as 'beforefieldinit'.
		static SteamClientClass()
		{
			Il2CppClassPointerStore<SteamClientClass<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamClientClass`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamClientClass<T>>.NativeClassPtr);
			SteamClientClass<T>.NativeFieldInfoPtr_Interface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamClientClass<T>>.NativeClassPtr, "Interface");
			SteamClientClass<T>.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClientClass<T>>.NativeClassPtr, 100666440);
			SteamClientClass<T>.NativeMethodInfoPtr_SetInterface_Internal_Virtual_New_Void_Boolean_SteamInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClientClass<T>>.NativeClassPtr, 100666441);
			SteamClientClass<T>.NativeMethodInfoPtr_DestroyInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClientClass<T>>.NativeClassPtr, 100666442);
			SteamClientClass<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClientClass<T>>.NativeClassPtr, 100666443);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00054204 File Offset: 0x00052404
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamClientClass<T>.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00054250 File Offset: 0x00052450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948210, XrefRangeEnd = 948217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamClientClass<T>.NativeMethodInfoPtr_SetInterface_Internal_Virtual_New_Void_Boolean_SteamInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000542AC File Offset: 0x000524AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948217, XrefRangeEnd = 948220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamClientClass<T>.NativeMethodInfoPtr_DestroyInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000542F8 File Offset: 0x000524F8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamClientClass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamClientClass<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClientClass<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000033D6 File Offset: 0x000015D6
		public SteamClientClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00054334 File Offset: 0x00052534
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x000033DF File Offset: 0x000015DF
		public unsafe static SteamInterface Interface
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamClientClass<T>.NativeFieldInfoPtr_Interface, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamInterface>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamClientClass<T>.NativeFieldInfoPtr_Interface, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeFieldInfoPtr_Interface;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr_SetInterface_Internal_Virtual_New_Void_Boolean_SteamInterface_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_DestroyInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
