using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003C RID: 60
	public class ToggleGroup : UIBehaviour
	{
		// Token: 0x060007C6 RID: 1990 RVA: 0x00025958 File Offset: 0x00023B58
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleGroup()
		{
			Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ToggleGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr);
			ToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, "m_AllowSwitchOff");
			ToggleGroup.NativeFieldInfoPtr_m_Toggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, "m_Toggles");
			ToggleGroup.NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664553);
			ToggleGroup.NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664554);
			ToggleGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664555);
			ToggleGroup.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664556);
			ToggleGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664557);
			ToggleGroup.NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664558);
			ToggleGroup.NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664559);
			ToggleGroup.NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664560);
			ToggleGroup.NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664561);
			ToggleGroup.NativeMethodInfoPtr_EnsureValidState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664562);
			ToggleGroup.NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664563);
			ToggleGroup.NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664564);
			ToggleGroup.NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664565);
			ToggleGroup.NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664566);
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00025AC8 File Offset: 0x00023CC8
		// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00025B04 File Offset: 0x00023D04
		public unsafe bool allowSwitchOff
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00025B44 File Offset: 0x00023D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093021, RefRangeEnd = 1093022, XrefRangeStart = 1093013, XrefRangeEnd = 1093021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00025B80 File Offset: 0x00023D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093022, XrefRangeEnd = 1093024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleGroup.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00025BBC File Offset: 0x00023DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00025BF8 File Offset: 0x00023DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093024, XrefRangeEnd = 1093031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateToggleIsInGroup(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00025C3C File Offset: 0x00023E3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1093053, RefRangeEnd = 1093056, XrefRangeStart = 1093031, XrefRangeEnd = 1093053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyToggleOn(Toggle toggle, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00025C8C File Offset: 0x00023E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093056, XrefRangeEnd = 1093062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterToggle(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00025CD0 File Offset: 0x00023ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093062, XrefRangeEnd = 1093068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterToggle(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00025D14 File Offset: 0x00023F14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1093113, RefRangeEnd = 1093116, XrefRangeStart = 1093068, XrefRangeEnd = 1093113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureValidState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_EnsureValidState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00025D48 File Offset: 0x00023F48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1093139, RefRangeEnd = 1093141, XrefRangeStart = 1093116, XrefRangeEnd = 1093139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyTogglesOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00025D84 File Offset: 0x00023F84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1093159, RefRangeEnd = 1093162, XrefRangeStart = 1093141, XrefRangeEnd = 1093159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Toggle> ActiveToggles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Toggle>>(intPtr3) : null;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00025DC4 File Offset: 0x00023FC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1093169, RefRangeEnd = 1093171, XrefRangeStart = 1093162, XrefRangeEnd = 1093169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toggle GetFirstActiveToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00025E04 File Offset: 0x00024004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1093181, RefRangeEnd = 1093182, XrefRangeStart = 1093171, XrefRangeEnd = 1093181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllTogglesOff(bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sendCallback;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00004A5F File Offset: 0x00002C5F
		public ToggleGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00025E44 File Offset: 0x00024044
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00004A68 File Offset: 0x00002C68
		public unsafe bool m_AllowSwitchOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff)) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00025E6C File Offset: 0x0002406C
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x00004A83 File Offset: 0x00002C83
		public unsafe List<Toggle> m_Toggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_Toggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Toggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_Toggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowSwitchOff;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_m_Toggles;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_EnsureValidState_Public_Void_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0;

		// Token: 0x020000BA RID: 186
		[ObfuscatedName("UnityEngine.UI.ToggleGroup+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000CF3 RID: 3315 RVA: 0x00037B48 File Offset: 0x00035D48
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr);
				ToggleGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, "<>9");
				ToggleGroup.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, "<>9__13_0");
				ToggleGroup.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, "<>9__14_0");
				ToggleGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, 100664568);
				ToggleGroup.__c.NativeMethodInfoPtr__AnyTogglesOn_b__13_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, 100664569);
				ToggleGroup.__c.NativeMethodInfoPtr__ActiveToggles_b__14_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, 100664570);
			}

			// Token: 0x06000CF4 RID: 3316 RVA: 0x00037BEC File Offset: 0x00035DEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CF5 RID: 3317 RVA: 0x00037C28 File Offset: 0x00035E28
			[CallerCount(0)]
			public unsafe bool _AnyTogglesOn_b__13_0(Toggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.__c.NativeMethodInfoPtr__AnyTogglesOn_b__13_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CF6 RID: 3318 RVA: 0x00037C78 File Offset: 0x00035E78
			[CallerCount(0)]
			public unsafe bool _ActiveToggles_b__14_0(Toggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.__c.NativeMethodInfoPtr__ActiveToggles_b__14_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CF7 RID: 3319 RVA: 0x00006EDF File Offset: 0x000050DF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000446 RID: 1094
			// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00037CC8 File Offset: 0x00035EC8
			// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00006EE8 File Offset: 0x000050E8
			public unsafe static ToggleGroup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGroup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000447 RID: 1095
			// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00037CF0 File Offset: 0x00035EF0
			// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00006EFA File Offset: 0x000050FA
			public unsafe static Predicate<Toggle> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroup.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Toggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroup.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000448 RID: 1096
			// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00037D18 File Offset: 0x00035F18
			// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00006F0C File Offset: 0x0000510C
			public unsafe static Func<Toggle, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroup.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Toggle, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroup.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A1B RID: 2587
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000A1C RID: 2588
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04000A1D RID: 2589
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04000A1E RID: 2590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A1F RID: 2591
			private static readonly IntPtr NativeMethodInfoPtr__AnyTogglesOn_b__13_0_Internal_Boolean_Toggle_0;

			// Token: 0x04000A20 RID: 2592
			private static readonly IntPtr NativeMethodInfoPtr__ActiveToggles_b__14_0_Internal_Boolean_Toggle_0;
		}
	}
}
