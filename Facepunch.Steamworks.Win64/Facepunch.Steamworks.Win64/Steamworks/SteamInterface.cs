using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000C8 RID: 200
	public class SteamInterface : Object
	{
		// Token: 0x06000CBB RID: 3259 RVA: 0x000538F8 File Offset: 0x00051AF8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInterface()
		{
			Il2CppClassPointerStore<SteamInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr);
			SteamInterface.NativeFieldInfoPtr_Self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, "Self");
			SteamInterface.NativeFieldInfoPtr_SelfGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, "SelfGlobal");
			SteamInterface.NativeFieldInfoPtr_SelfServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, "SelfServer");
			SteamInterface.NativeFieldInfoPtr_SelfClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, "SelfClient");
			SteamInterface.NativeFieldInfoPtr__IsServer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, "<IsServer>k__BackingField");
			SteamInterface.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_New_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, 100666423);
			SteamInterface.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_New_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, 100666424);
			SteamInterface.NativeMethodInfoPtr_GetGlobalInterfacePointer_Public_Virtual_New_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, 100666425);
			SteamInterface.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, 100666426);
			SteamInterface.NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, 100666427);
			SteamInterface.NativeMethodInfoPtr_set_IsServer_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, 100666428);
			SteamInterface.NativeMethodInfoPtr_SetupInterface_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, 100666429);
			SteamInterface.NativeMethodInfoPtr_ShutdownInterface_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, 100666430);
			SteamInterface.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr, 100666431);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00053A40 File Offset: 0x00051C40
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamInterface.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_New_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00053A88 File Offset: 0x00051C88
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IntPtr GetServerInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamInterface.NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_New_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00053AD0 File Offset: 0x00051CD0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IntPtr GetGlobalInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamInterface.NativeMethodInfoPtr_GetGlobalInterfacePointer_Public_Virtual_New_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00053B18 File Offset: 0x00051D18
		public unsafe bool IsValid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 948145, RefRangeEnd = 948147, XrefRangeStart = 948144, XrefRangeEnd = 948145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInterface.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00053B54 File Offset: 0x00051D54
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00053B90 File Offset: 0x00051D90
		public unsafe bool IsServer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInterface.NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInterface.NativeMethodInfoPtr_set_IsServer_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00053BD0 File Offset: 0x00051DD0
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 948149, RefRangeEnd = 948184, XrefRangeStart = 948147, XrefRangeEnd = 948149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupInterface(bool gameServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInterface.NativeMethodInfoPtr_SetupInterface_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00053C10 File Offset: 0x00051E10
		[CallerCount(0)]
		public unsafe void ShutdownInterface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInterface.NativeMethodInfoPtr_ShutdownInterface_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00053C44 File Offset: 0x00051E44
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamInterface()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInterface.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00003310 File Offset: 0x00001510
		public SteamInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00053C80 File Offset: 0x00051E80
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00003319 File Offset: 0x00001519
		public unsafe IntPtr Self
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInterface.NativeFieldInfoPtr_Self);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInterface.NativeFieldInfoPtr_Self)) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00053CA8 File Offset: 0x00051EA8
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x00003334 File Offset: 0x00001534
		public unsafe IntPtr SelfGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInterface.NativeFieldInfoPtr_SelfGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInterface.NativeFieldInfoPtr_SelfGlobal)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00053CD0 File Offset: 0x00051ED0
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x0000334F File Offset: 0x0000154F
		public unsafe IntPtr SelfServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInterface.NativeFieldInfoPtr_SelfServer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInterface.NativeFieldInfoPtr_SelfServer)) = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00053CF8 File Offset: 0x00051EF8
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x0000336A File Offset: 0x0000156A
		public unsafe IntPtr SelfClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInterface.NativeFieldInfoPtr_SelfClient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInterface.NativeFieldInfoPtr_SelfClient)) = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00053D20 File Offset: 0x00051F20
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00003385 File Offset: 0x00001585
		public unsafe bool _IsServer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInterface.NativeFieldInfoPtr__IsServer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInterface.NativeFieldInfoPtr__IsServer_k__BackingField)) = value;
			}
		}

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeFieldInfoPtr_Self;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeFieldInfoPtr_SelfGlobal;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeFieldInfoPtr_SelfServer;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeFieldInfoPtr_SelfClient;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeFieldInfoPtr__IsServer_k__BackingField;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_New_IntPtr_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_GetServerInterfacePointer_Public_Virtual_New_IntPtr_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalInterfacePointer_Public_Virtual_New_IntPtr_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_get_IsServer_Public_get_Boolean_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_set_IsServer_Private_set_Void_Boolean_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_SetupInterface_Internal_Void_Boolean_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_ShutdownInterface_Internal_Void_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
