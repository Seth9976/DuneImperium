using System;
using boardgames.match.selection;
using dwd.core.match;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x020001C6 RID: 454
	public class UndoButton : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x060013DD RID: 5085 RVA: 0x000547E8 File Offset: 0x000529E8
		// Note: this type is marked as 'beforefieldinit'.
		static UndoButton()
		{
			Il2CppClassPointerStore<UndoButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "UndoButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndoButton>.NativeClassPtr);
			UndoButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, "button");
			UndoButton.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, "provider");
			UndoButton.NativeFieldInfoPtr_undoAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, "undoAbility");
			UndoButton.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, "root");
			UndoButton.NativeFieldInfoPtr_NoUndoPickers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, "NoUndoPickers");
			UndoButton.NativeMethodInfoPtr_get_isUndoAsCancel_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, 100666032);
			UndoButton.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, 100666033);
			UndoButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, 100666034);
			UndoButton.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, 100666035);
			UndoButton.NativeMethodInfoPtr_Event_Click_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, 100666036);
			UndoButton.NativeMethodInfoPtr_HideUndo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, 100666037);
			UndoButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndoButton>.NativeClassPtr, 100666038);
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x00054908 File Offset: 0x00052B08
		public unsafe bool isUndoAsCancel
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 713472, RefRangeEnd = 713474, XrefRangeStart = 713457, XrefRangeEnd = 713472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoButton.NativeMethodInfoPtr_get_isUndoAsCancel_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00054944 File Offset: 0x00052B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713474, XrefRangeEnd = 713481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndoButton.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00054980 File Offset: 0x00052B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713481, XrefRangeEnd = 713505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndoButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x000549BC File Offset: 0x00052BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713505, XrefRangeEnd = 713553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UndoButton.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x000549F8 File Offset: 0x00052BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713553, XrefRangeEnd = 713568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Click()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoButton.NativeMethodInfoPtr_Event_Click_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00054A2C File Offset: 0x00052C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 713570, RefRangeEnd = 713571, XrefRangeStart = 713568, XrefRangeEnd = 713570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideUndo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoButton.NativeMethodInfoPtr_HideUndo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00054A60 File Offset: 0x00052C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713571, XrefRangeEnd = 713574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndoButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndoButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndoButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0000C30B File Offset: 0x0000A50B
		public UndoButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x00054A9C File Offset: 0x00052C9C
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x0000C314 File Offset: 0x0000A514
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00054ACC File Offset: 0x00052CCC
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x0000C333 File Offset: 0x0000A533
		public unsafe EntitiesProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoButton.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoButton.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x00054AFC File Offset: 0x00052CFC
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x0000C352 File Offset: 0x0000A552
		public unsafe EntityComponent undoAbility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoButton.NativeFieldInfoPtr_undoAbility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoButton.NativeFieldInfoPtr_undoAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00054B2C File Offset: 0x00052D2C
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x0000C371 File Offset: 0x0000A571
		public unsafe GameObject root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoButton.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UndoButton.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00054B5C File Offset: 0x00052D5C
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x0000C390 File Offset: 0x0000A590
		public unsafe static IReadOnlyList<string> NoUndoPickers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UndoButton.NativeFieldInfoPtr_NoUndoPickers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UndoButton.NativeFieldInfoPtr_NoUndoPickers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeFieldInfoPtr_undoAbility;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeFieldInfoPtr_NoUndoPickers;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_get_isUndoAsCancel_Private_get_Boolean_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_Event_Click_Public_Void_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_HideUndo_Public_Void_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
