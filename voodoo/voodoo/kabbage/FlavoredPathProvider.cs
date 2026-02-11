using System;
using dwd.core.match.data;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace voodoo.kabbage
{
	// Token: 0x0200001D RID: 29
	public class FlavoredPathProvider : PathProvider
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x0000BD44 File Offset: 0x00009F44
		// Note: this type is marked as 'beforefieldinit'.
		static FlavoredPathProvider()
		{
			Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "FlavoredPathProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr);
			FlavoredPathProvider.NativeFieldInfoPtr_LOG_LOOKUPS_PREF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, "LOG_LOOKUPS_PREF");
			FlavoredPathProvider.NativeFieldInfoPtr_prefabLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, "prefabLoader");
			FlavoredPathProvider.NativeFieldInfoPtr_logInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, "logInEditor");
			FlavoredPathProvider.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, "entitiesProvider");
			FlavoredPathProvider.NativeFieldInfoPtr_preparedMoveContextFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, "preparedMoveContextFlavors");
			FlavoredPathProvider.NativeMethodInfoPtr_Init_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, 100663398);
			FlavoredPathProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, 100663399);
			FlavoredPathProvider.NativeMethodInfoPtr_PrepareMoveContextFlavors_Public_Void_MoveContext_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, 100663400);
			FlavoredPathProvider.NativeMethodInfoPtr_AddPathToContext_Public_Virtual_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, 100663401);
			FlavoredPathProvider.NativeMethodInfoPtr_finalizePrefabContext_Protected_Virtual_New_PrefabFlavorContext_PrefabFlavorContext_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, 100663402);
			FlavoredPathProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr, 100663403);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000BE50 File Offset: 0x0000A050
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlavoredPathProvider.NativeMethodInfoPtr_Init_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000BE8C File Offset: 0x0000A08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107016, XrefRangeEnd = 1107019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredPathProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107019, XrefRangeEnd = 1107023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareMoveContextFlavors(MoveContext context, List<string> flavors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flavors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredPathProvider.NativeMethodInfoPtr_PrepareMoveContextFlavors_Public_Void_MoveContext_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000BF14 File Offset: 0x0000A114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107023, XrefRangeEnd = 1107070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddPathToContext(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlavoredPathProvider.NativeMethodInfoPtr_AddPathToContext_Public_Virtual_Void_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000BF64 File Offset: 0x0000A164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107070, XrefRangeEnd = 1107071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PrefabFlavorContext finalizePrefabContext(PrefabFlavorContext flavorContext, MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(flavorContext));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlavoredPathProvider.NativeMethodInfoPtr_finalizePrefabContext_Protected_Virtual_New_PrefabFlavorContext_PrefabFlavorContext_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PrefabFlavorContext(intPtr);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107071, XrefRangeEnd = 1107079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredPathProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredPathProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredPathProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002815 File Offset: 0x00000A15
		public FlavoredPathProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000C00C File Offset: 0x0000A20C
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000281E File Offset: 0x00000A1E
		public unsafe static string LOG_LOOKUPS_PREF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlavoredPathProvider.NativeFieldInfoPtr_LOG_LOOKUPS_PREF, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlavoredPathProvider.NativeFieldInfoPtr_LOG_LOOKUPS_PREF, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000C02C File Offset: 0x0000A22C
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002830 File Offset: 0x00000A30
		public unsafe PrefabByFlavorLoader prefabLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredPathProvider.NativeFieldInfoPtr_prefabLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredPathProvider.NativeFieldInfoPtr_prefabLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000C05C File Offset: 0x0000A25C
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000284F File Offset: 0x00000A4F
		public unsafe bool logInEditor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredPathProvider.NativeFieldInfoPtr_logInEditor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredPathProvider.NativeFieldInfoPtr_logInEditor)) = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000C084 File Offset: 0x0000A284
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000286A File Offset: 0x00000A6A
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredPathProvider.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredPathProvider.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002889 File Offset: 0x00000A89
		public unsafe Dictionary<MoveContext, List<string>> preparedMoveContextFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredPathProvider.NativeFieldInfoPtr_preparedMoveContextFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MoveContext, List<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredPathProvider.NativeFieldInfoPtr_preparedMoveContextFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_LOG_LOOKUPS_PREF;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_prefabLoader;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_logInEditor;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_preparedMoveContextFlavors;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_PrepareMoveContextFlavors_Public_Void_MoveContext_List_1_String_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_AddPathToContext_Public_Virtual_Void_MoveContext_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_finalizePrefabContext_Protected_Virtual_New_PrefabFlavorContext_PrefabFlavorContext_MoveContext_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
