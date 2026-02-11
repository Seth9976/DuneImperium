using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Steamworks
{
	// Token: 0x0200009E RID: 158
	public static class SteamClient : Object
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x000439E8 File Offset: 0x00041BE8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamClient()
		{
			Il2CppClassPointerStore<SteamClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamClient>.NativeClassPtr);
			SteamClient.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, "initialized");
			SteamClient.NativeFieldInfoPtr_openInterfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, "openInterfaces");
			SteamClient.NativeFieldInfoPtr__AppId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, "<AppId>k__BackingField");
			SteamClient.NativeMethodInfoPtr_Init_Public_Static_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665372);
			SteamClient.NativeMethodInfoPtr_AddInterface_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665373);
			SteamClient.NativeMethodInfoPtr_ShutdownInterfaces_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665374);
			SteamClient.NativeMethodInfoPtr_get_IsValid_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665375);
			SteamClient.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665376);
			SteamClient.NativeMethodInfoPtr_Cleanup_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665377);
			SteamClient.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665378);
			SteamClient.NativeMethodInfoPtr_get_IsLoggedOn_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665379);
			SteamClient.NativeMethodInfoPtr_get_SteamId_Public_Static_get_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665380);
			SteamClient.NativeMethodInfoPtr_get_Name_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665381);
			SteamClient.NativeMethodInfoPtr_get_State_Public_Static_get_FriendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665382);
			SteamClient.NativeMethodInfoPtr_get_AppId_Public_Static_get_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665383);
			SteamClient.NativeMethodInfoPtr_set_AppId_Internal_Static_set_Void_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665384);
			SteamClient.NativeMethodInfoPtr_RestartAppIfNecessary_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665385);
			SteamClient.NativeMethodInfoPtr_ValidCheck_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100665386);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00043B80 File Offset: 0x00041D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937440, XrefRangeEnd = 937533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init(uint appid, bool asyncCallbacks = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asyncCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_Init_Public_Static_Void_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00043BC0 File Offset: 0x00041DC0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 937545, RefRangeEnd = 937565, XrefRangeStart = 937533, XrefRangeEnd = 937545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddInterface<T>() where T : SteamClass, new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.MethodInfoStoreGeneric_AddInterface_Internal_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00043BE8 File Offset: 0x00041DE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 937588, RefRangeEnd = 937590, XrefRangeStart = 937565, XrefRangeEnd = 937588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShutdownInterfaces()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_ShutdownInterfaces_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00043C10 File Offset: 0x00041E10
		public unsafe static bool IsValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937590, XrefRangeEnd = 937594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_get_IsValid_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00043C40 File Offset: 0x00041E40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 937613, RefRangeEnd = 937614, XrefRangeStart = 937594, XrefRangeEnd = 937613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00043C68 File Offset: 0x00041E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 937623, RefRangeEnd = 937625, XrefRangeStart = 937614, XrefRangeEnd = 937623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Cleanup()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_Cleanup_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00043C90 File Offset: 0x00041E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 937641, RefRangeEnd = 937642, XrefRangeStart = 937625, XrefRangeEnd = 937641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunCallbacks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00043CB8 File Offset: 0x00041EB8
		public unsafe static bool IsLoggedOn
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 937648, RefRangeEnd = 937652, XrefRangeStart = 937642, XrefRangeEnd = 937648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_get_IsLoggedOn_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00043CE8 File Offset: 0x00041EE8
		public unsafe static SteamId SteamId
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 937658, RefRangeEnd = 937667, XrefRangeStart = 937652, XrefRangeEnd = 937658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_get_SteamId_Public_Static_get_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00043D18 File Offset: 0x00041F18
		public unsafe static string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937667, XrefRangeEnd = 937670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_get_Name_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00043D44 File Offset: 0x00041F44
		public unsafe static FriendState State
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937670, XrefRangeEnd = 937673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_get_State_Public_Static_get_FriendState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00043D74 File Offset: 0x00041F74
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x00043DA4 File Offset: 0x00041FA4
		public unsafe static AppId AppId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937673, XrefRangeEnd = 937677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_get_AppId_Public_Static_get_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937677, XrefRangeEnd = 937681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_set_AppId_Internal_Static_set_Void_AppId_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00043DD8 File Offset: 0x00041FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 937682, RefRangeEnd = 937683, XrefRangeStart = 937681, XrefRangeEnd = 937682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RestartAppIfNecessary(uint appid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appid;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_RestartAppIfNecessary_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00043E18 File Offset: 0x00042018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 937683, XrefRangeEnd = 937690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidCheck()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_ValidCheck_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000026A9 File Offset: 0x000008A9
		public SteamClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00043E40 File Offset: 0x00042040
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x000026B2 File Offset: 0x000008B2
		public unsafe static bool initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SteamClient.NativeFieldInfoPtr_initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamClient.NativeFieldInfoPtr_initialized, (void*)(&value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00043E5C File Offset: 0x0004205C
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000026C0 File Offset: 0x000008C0
		public unsafe static List<SteamClass> openInterfaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamClient.NativeFieldInfoPtr_openInterfaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SteamClass>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamClient.NativeFieldInfoPtr_openInterfaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00043E84 File Offset: 0x00042084
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x000026D2 File Offset: 0x000008D2
		public unsafe static AppId _AppId_k__BackingField
		{
			get
			{
				AppId appId;
				IL2CPP.il2cpp_field_static_get_value(SteamClient.NativeFieldInfoPtr__AppId_k__BackingField, (void*)(&appId));
				return appId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamClient.NativeFieldInfoPtr__AppId_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeFieldInfoPtr_openInterfaces;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeFieldInfoPtr__AppId_k__BackingField;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_UInt32_Boolean_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_AddInterface_Internal_Static_Void_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_ShutdownInterfaces_Internal_Static_Void_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Static_get_Boolean_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Void_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Static_Void_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoggedOn_Public_Static_get_Boolean_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_get_SteamId_Public_Static_get_SteamId_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Static_get_String_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_Static_get_FriendState_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_get_AppId_Public_Static_get_AppId_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_set_AppId_Internal_Static_set_Void_AppId_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_RestartAppIfNecessary_Public_Static_Boolean_UInt32_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_ValidCheck_Internal_Static_Void_0;

		// Token: 0x02000221 RID: 545
		private sealed class MethodInfoStoreGeneric_AddInterface_Internal_Static_Void_0<T>
		{
			// Token: 0x04002012 RID: 8210
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SteamClient.NativeMethodInfoPtr_AddInterface_Internal_Static_Void_0, Il2CppClassPointerStore<SteamClient>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
