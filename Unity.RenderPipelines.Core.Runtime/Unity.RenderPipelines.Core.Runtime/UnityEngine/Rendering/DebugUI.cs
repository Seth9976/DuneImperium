using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text.RegularExpressions;

namespace UnityEngine.Rendering
{
	// Token: 0x02000068 RID: 104
	public class DebugUI : Object
	{
		// Token: 0x06000766 RID: 1894 RVA: 0x00004F35 File Offset: 0x00003135
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUI()
		{
			Il2CppClassPointerStore<DebugUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI>.NativeClassPtr);
			DebugUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, 100664310);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00029770 File Offset: 0x00027970
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00004F6E File Offset: 0x0000316E
		public DebugUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000192 RID: 402
		public class Container : DebugUI.Widget
		{
			// Token: 0x060016BC RID: 5820 RVA: 0x00061D2C File Offset: 0x0005FF2C
			// Note: this type is marked as 'beforefieldinit'.
			static Container()
			{
				Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Container");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr);
				DebugUI.Container.NativeFieldInfoPtr_k_IDToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, "k_IDToken");
				DebugUI.Container.NativeFieldInfoPtr__children_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, "<children>k__BackingField");
				DebugUI.Container.NativeMethodInfoPtr_get_hideDisplayName_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664311);
				DebugUI.Container.NativeMethodInfoPtr_get_children_Public_Virtual_Final_New_get_ObservableList_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664312);
				DebugUI.Container.NativeMethodInfoPtr_set_children_Private_set_Void_ObservableList_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664313);
				DebugUI.Container.NativeMethodInfoPtr_get_panel_Public_Virtual_get_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664314);
				DebugUI.Container.NativeMethodInfoPtr_set_panel_Internal_Virtual_set_Void_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664315);
				DebugUI.Container.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664316);
				DebugUI.Container.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664317);
				DebugUI.Container.NativeMethodInfoPtr__ctor_Public_Void_String_ObservableList_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664318);
				DebugUI.Container.NativeMethodInfoPtr_GenerateQueryPath_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664319);
				DebugUI.Container.NativeMethodInfoPtr_OnItemAdded_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664320);
				DebugUI.Container.NativeMethodInfoPtr_OnItemRemoved_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664321);
				DebugUI.Container.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr, 100664322);
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x060016BD RID: 5821 RVA: 0x00061E70 File Offset: 0x00060070
			public unsafe bool hideDisplayName
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 963761, RefRangeEnd = 963762, XrefRangeStart = 963759, XrefRangeEnd = 963761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Container.NativeMethodInfoPtr_get_hideDisplayName_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x060016BE RID: 5822 RVA: 0x00061EAC File Offset: 0x000600AC
			// (set) Token: 0x060016BF RID: 5823 RVA: 0x00061EEC File Offset: 0x000600EC
			public unsafe virtual ObservableList<DebugUI.Widget> children
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Container.NativeMethodInfoPtr_get_children_Public_Virtual_Final_New_get_ObservableList_1_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObservableList<DebugUI.Widget>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Container.NativeMethodInfoPtr_set_children_Private_set_Void_ObservableList_1_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x060016C0 RID: 5824 RVA: 0x00061F30 File Offset: 0x00060130
			// (set) Token: 0x060016C1 RID: 5825 RVA: 0x00061F7C File Offset: 0x0006017C
			public unsafe override DebugUI.Panel panel
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Container.NativeMethodInfoPtr_get_panel_Public_Virtual_get_Panel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Panel>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963762, XrefRangeEnd = 963769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Container.NativeMethodInfoPtr_set_panel_Internal_Virtual_set_Void_Panel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060016C2 RID: 5826 RVA: 0x00061FCC File Offset: 0x000601CC
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 963778, RefRangeEnd = 963803, XrefRangeStart = 963769, XrefRangeEnd = 963778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Container()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Container.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016C3 RID: 5827 RVA: 0x00062008 File Offset: 0x00060208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963803, XrefRangeEnd = 963813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Container(string id)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Container.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016C4 RID: 5828 RVA: 0x00062054 File Offset: 0x00060254
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 963842, RefRangeEnd = 963845, XrefRangeStart = 963813, XrefRangeEnd = 963842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Container(string displayName, ObservableList<DebugUI.Widget> children)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Container>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(children);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Container.NativeMethodInfoPtr__ctor_Public_Void_String_ObservableList_1_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016C5 RID: 5829 RVA: 0x000620B4 File Offset: 0x000602B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963845, XrefRangeEnd = 963860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void GenerateQueryPath()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Container.NativeMethodInfoPtr_GenerateQueryPath_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016C6 RID: 5830 RVA: 0x000620F0 File Offset: 0x000602F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963860, XrefRangeEnd = 963861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnItemAdded(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Container.NativeMethodInfoPtr_OnItemAdded_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016C7 RID: 5831 RVA: 0x00062150 File Offset: 0x00060350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963861, XrefRangeEnd = 963862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnItemRemoved(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Container.NativeMethodInfoPtr_OnItemRemoved_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016C8 RID: 5832 RVA: 0x000621B0 File Offset: 0x000603B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963862, XrefRangeEnd = 963873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Container.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060016C9 RID: 5833 RVA: 0x0000B64B File Offset: 0x0000984B
			public Container(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x060016CA RID: 5834 RVA: 0x000621F8 File Offset: 0x000603F8
			// (set) Token: 0x060016CB RID: 5835 RVA: 0x0000B654 File Offset: 0x00009854
			public unsafe static string k_IDToken
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugUI.Container.NativeFieldInfoPtr_k_IDToken, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugUI.Container.NativeFieldInfoPtr_k_IDToken, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x060016CC RID: 5836 RVA: 0x00062218 File Offset: 0x00060418
			// (set) Token: 0x060016CD RID: 5837 RVA: 0x0000B666 File Offset: 0x00009866
			public unsafe ObservableList<DebugUI.Widget> _children_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Container.NativeFieldInfoPtr__children_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObservableList<DebugUI.Widget>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Container.NativeFieldInfoPtr__children_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001088 RID: 4232
			private static readonly IntPtr NativeFieldInfoPtr_k_IDToken;

			// Token: 0x04001089 RID: 4233
			private static readonly IntPtr NativeFieldInfoPtr__children_k__BackingField;

			// Token: 0x0400108A RID: 4234
			private static readonly IntPtr NativeMethodInfoPtr_get_hideDisplayName_Internal_get_Boolean_0;

			// Token: 0x0400108B RID: 4235
			private static readonly IntPtr NativeMethodInfoPtr_get_children_Public_Virtual_Final_New_get_ObservableList_1_Widget_0;

			// Token: 0x0400108C RID: 4236
			private static readonly IntPtr NativeMethodInfoPtr_set_children_Private_set_Void_ObservableList_1_Widget_0;

			// Token: 0x0400108D RID: 4237
			private static readonly IntPtr NativeMethodInfoPtr_get_panel_Public_Virtual_get_Panel_0;

			// Token: 0x0400108E RID: 4238
			private static readonly IntPtr NativeMethodInfoPtr_set_panel_Internal_Virtual_set_Void_Panel_0;

			// Token: 0x0400108F RID: 4239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001090 RID: 4240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04001091 RID: 4241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ObservableList_1_Widget_0;

			// Token: 0x04001092 RID: 4242
			private static readonly IntPtr NativeMethodInfoPtr_GenerateQueryPath_Internal_Virtual_Void_0;

			// Token: 0x04001093 RID: 4243
			private static readonly IntPtr NativeMethodInfoPtr_OnItemAdded_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0;

			// Token: 0x04001094 RID: 4244
			private static readonly IntPtr NativeMethodInfoPtr_OnItemRemoved_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0;

			// Token: 0x04001095 RID: 4245
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
		}

		// Token: 0x02000193 RID: 403
		public class Foldout : DebugUI.Container
		{
			// Token: 0x060016CE RID: 5838 RVA: 0x00062248 File Offset: 0x00060448
			// Note: this type is marked as 'beforefieldinit'.
			static Foldout()
			{
				Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Foldout");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr);
				DebugUI.Foldout.NativeFieldInfoPtr_opened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, "opened");
				DebugUI.Foldout.NativeFieldInfoPtr_isHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, "isHeader");
				DebugUI.Foldout.NativeFieldInfoPtr_contextMenuItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, "contextMenuItems");
				DebugUI.Foldout.NativeFieldInfoPtr__columnLabels_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, "<columnLabels>k__BackingField");
				DebugUI.Foldout.NativeFieldInfoPtr__columnTooltips_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, "<columnTooltips>k__BackingField");
				DebugUI.Foldout.NativeMethodInfoPtr_get_isReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664323);
				DebugUI.Foldout.NativeMethodInfoPtr_get_columnLabels_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664324);
				DebugUI.Foldout.NativeMethodInfoPtr_set_columnLabels_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664325);
				DebugUI.Foldout.NativeMethodInfoPtr_get_columnTooltips_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664326);
				DebugUI.Foldout.NativeMethodInfoPtr_set_columnTooltips_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664327);
				DebugUI.Foldout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664328);
				DebugUI.Foldout.NativeMethodInfoPtr__ctor_Public_Void_String_ObservableList_1_Widget_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664329);
				DebugUI.Foldout.NativeMethodInfoPtr_GetValue_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664330);
				DebugUI.Foldout.NativeMethodInfoPtr_UnityEngine_Rendering_DebugUI_IValueField_GetValue_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664331);
				DebugUI.Foldout.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664332);
				DebugUI.Foldout.NativeMethodInfoPtr_ValidateValue_Public_Virtual_Final_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664333);
				DebugUI.Foldout.NativeMethodInfoPtr_SetValue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, 100664334);
			}

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x060016CF RID: 5839 RVA: 0x000623C8 File Offset: 0x000605C8
			public unsafe bool isReadOnly
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr_get_isReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x060016D0 RID: 5840 RVA: 0x00062404 File Offset: 0x00060604
			// (set) Token: 0x060016D1 RID: 5841 RVA: 0x00062444 File Offset: 0x00060644
			public unsafe Il2CppStringArray columnLabels
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr_get_columnLabels_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr_set_columnLabels_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x060016D2 RID: 5842 RVA: 0x00062488 File Offset: 0x00060688
			// (set) Token: 0x060016D3 RID: 5843 RVA: 0x000624C8 File Offset: 0x000606C8
			public unsafe Il2CppStringArray columnTooltips
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr_get_columnTooltips_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr_set_columnTooltips_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060016D4 RID: 5844 RVA: 0x0006250C File Offset: 0x0006070C
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 963874, RefRangeEnd = 963880, XrefRangeStart = 963873, XrefRangeEnd = 963874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Foldout()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016D5 RID: 5845 RVA: 0x00062548 File Offset: 0x00060748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963880, XrefRangeEnd = 963883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Foldout(string displayName, ObservableList<DebugUI.Widget> children, Il2CppStringArray columnLabels = null, Il2CppStringArray columnTooltips = null)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(children);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columnLabels);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columnTooltips);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr__ctor_Public_Void_String_ObservableList_1_Widget_Il2CppStringArray_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016D6 RID: 5846 RVA: 0x000625CC File Offset: 0x000607CC
			[CallerCount(0)]
			public unsafe bool GetValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr_GetValue_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060016D7 RID: 5847 RVA: 0x00062608 File Offset: 0x00060808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963883, XrefRangeEnd = 963886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object UnityEngine_Rendering_DebugUI_IValueField_GetValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr_UnityEngine_Rendering_DebugUI_IValueField_GetValue_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060016D8 RID: 5848 RVA: 0x00062648 File Offset: 0x00060848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963886, XrefRangeEnd = 963889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetValue(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016D9 RID: 5849 RVA: 0x0006268C File Offset: 0x0006088C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object ValidateValue(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr_ValidateValue_Public_Virtual_Final_New_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060016DA RID: 5850 RVA: 0x000626DC File Offset: 0x000608DC
			[CallerCount(0)]
			public unsafe void SetValue(bool value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Foldout.NativeMethodInfoPtr_SetValue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016DB RID: 5851 RVA: 0x0000B685 File Offset: 0x00009885
			public Foldout(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x060016DC RID: 5852 RVA: 0x0006271C File Offset: 0x0006091C
			// (set) Token: 0x060016DD RID: 5853 RVA: 0x0000B68E File Offset: 0x0000988E
			public unsafe bool opened
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.NativeFieldInfoPtr_opened);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.NativeFieldInfoPtr_opened)) = value;
				}
			}

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x060016DE RID: 5854 RVA: 0x00062744 File Offset: 0x00060944
			// (set) Token: 0x060016DF RID: 5855 RVA: 0x0000B6A9 File Offset: 0x000098A9
			public unsafe bool isHeader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.NativeFieldInfoPtr_isHeader);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.NativeFieldInfoPtr_isHeader)) = value;
				}
			}

			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x060016E0 RID: 5856 RVA: 0x0006276C File Offset: 0x0006096C
			// (set) Token: 0x060016E1 RID: 5857 RVA: 0x0000B6C4 File Offset: 0x000098C4
			public unsafe List<DebugUI.Foldout.ContextMenuItem> contextMenuItems
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.NativeFieldInfoPtr_contextMenuItems);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DebugUI.Foldout.ContextMenuItem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.NativeFieldInfoPtr_contextMenuItems), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0006279C File Offset: 0x0006099C
			// (set) Token: 0x060016E3 RID: 5859 RVA: 0x0000B6E3 File Offset: 0x000098E3
			public unsafe Il2CppStringArray _columnLabels_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.NativeFieldInfoPtr__columnLabels_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.NativeFieldInfoPtr__columnLabels_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x060016E4 RID: 5860 RVA: 0x000627CC File Offset: 0x000609CC
			// (set) Token: 0x060016E5 RID: 5861 RVA: 0x0000B702 File Offset: 0x00009902
			public unsafe Il2CppStringArray _columnTooltips_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.NativeFieldInfoPtr__columnTooltips_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.NativeFieldInfoPtr__columnTooltips_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001096 RID: 4246
			private static readonly IntPtr NativeFieldInfoPtr_opened;

			// Token: 0x04001097 RID: 4247
			private static readonly IntPtr NativeFieldInfoPtr_isHeader;

			// Token: 0x04001098 RID: 4248
			private static readonly IntPtr NativeFieldInfoPtr_contextMenuItems;

			// Token: 0x04001099 RID: 4249
			private static readonly IntPtr NativeFieldInfoPtr__columnLabels_k__BackingField;

			// Token: 0x0400109A RID: 4250
			private static readonly IntPtr NativeFieldInfoPtr__columnTooltips_k__BackingField;

			// Token: 0x0400109B RID: 4251
			private static readonly IntPtr NativeMethodInfoPtr_get_isReadOnly_Public_get_Boolean_0;

			// Token: 0x0400109C RID: 4252
			private static readonly IntPtr NativeMethodInfoPtr_get_columnLabels_Public_get_Il2CppStringArray_0;

			// Token: 0x0400109D RID: 4253
			private static readonly IntPtr NativeMethodInfoPtr_set_columnLabels_Public_set_Void_Il2CppStringArray_0;

			// Token: 0x0400109E RID: 4254
			private static readonly IntPtr NativeMethodInfoPtr_get_columnTooltips_Public_get_Il2CppStringArray_0;

			// Token: 0x0400109F RID: 4255
			private static readonly IntPtr NativeMethodInfoPtr_set_columnTooltips_Public_set_Void_Il2CppStringArray_0;

			// Token: 0x040010A0 RID: 4256
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010A1 RID: 4257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ObservableList_1_Widget_Il2CppStringArray_Il2CppStringArray_0;

			// Token: 0x040010A2 RID: 4258
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Boolean_0;

			// Token: 0x040010A3 RID: 4259
			private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Rendering_DebugUI_IValueField_GetValue_Private_Virtual_Final_New_Object_0;

			// Token: 0x040010A4 RID: 4260
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_0;

			// Token: 0x040010A5 RID: 4261
			private static readonly IntPtr NativeMethodInfoPtr_ValidateValue_Public_Virtual_Final_New_Object_Object_0;

			// Token: 0x040010A6 RID: 4262
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Boolean_0;

			// Token: 0x0200022F RID: 559
			public sealed class ContextMenuItem : ValueType
			{
				// Token: 0x06001BD3 RID: 7123 RVA: 0x00070E74 File Offset: 0x0006F074
				// Note: this type is marked as 'beforefieldinit'.
				static ContextMenuItem()
				{
					Il2CppClassPointerStore<DebugUI.Foldout.ContextMenuItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI.Foldout>.NativeClassPtr, "ContextMenuItem");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Foldout.ContextMenuItem>.NativeClassPtr);
					DebugUI.Foldout.ContextMenuItem.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Foldout.ContextMenuItem>.NativeClassPtr, "displayName");
					DebugUI.Foldout.ContextMenuItem.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Foldout.ContextMenuItem>.NativeClassPtr, "action");
				}

				// Token: 0x06001BD4 RID: 7124 RVA: 0x0000DEFE File Offset: 0x0000C0FE
				public ContextMenuItem(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001BD5 RID: 7125 RVA: 0x0000DF07 File Offset: 0x0000C107
				public ContextMenuItem()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Foldout.ContextMenuItem>.NativeClassPtr))
				{
				}

				// Token: 0x170007D2 RID: 2002
				// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00070EC8 File Offset: 0x0006F0C8
				// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x0000DF19 File Offset: 0x0000C119
				public unsafe string displayName
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.ContextMenuItem.NativeFieldInfoPtr_displayName);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.ContextMenuItem.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170007D3 RID: 2003
				// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00070EF0 File Offset: 0x0006F0F0
				// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x0000DF38 File Offset: 0x0000C138
				public unsafe Action action
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.ContextMenuItem.NativeFieldInfoPtr_action);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Foldout.ContextMenuItem.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001424 RID: 5156
				private static readonly IntPtr NativeFieldInfoPtr_displayName;

				// Token: 0x04001425 RID: 5157
				private static readonly IntPtr NativeFieldInfoPtr_action;
			}
		}

		// Token: 0x02000194 RID: 404
		public class HBox : DebugUI.Container
		{
			// Token: 0x060016E6 RID: 5862 RVA: 0x0000B721 File Offset: 0x00009921
			// Note: this type is marked as 'beforefieldinit'.
			static HBox()
			{
				Il2CppClassPointerStore<DebugUI.HBox>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "HBox");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.HBox>.NativeClassPtr);
				DebugUI.HBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HBox>.NativeClassPtr, 100664335);
			}

			// Token: 0x060016E7 RID: 5863 RVA: 0x000627FC File Offset: 0x000609FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963889, XrefRangeEnd = 963893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HBox()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.HBox>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016E8 RID: 5864 RVA: 0x0000B755 File Offset: 0x00009955
			public HBox(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010A7 RID: 4263
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000195 RID: 405
		public class VBox : DebugUI.Container
		{
			// Token: 0x060016E9 RID: 5865 RVA: 0x0000B75E File Offset: 0x0000995E
			// Note: this type is marked as 'beforefieldinit'.
			static VBox()
			{
				Il2CppClassPointerStore<DebugUI.VBox>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "VBox");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.VBox>.NativeClassPtr);
				DebugUI.VBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.VBox>.NativeClassPtr, 100664336);
			}

			// Token: 0x060016EA RID: 5866 RVA: 0x00062838 File Offset: 0x00060A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963893, XrefRangeEnd = 963897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VBox()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.VBox>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.VBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016EB RID: 5867 RVA: 0x0000B792 File Offset: 0x00009992
			public VBox(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010A8 RID: 4264
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000196 RID: 406
		public class Table : DebugUI.Container
		{
			// Token: 0x060016EC RID: 5868 RVA: 0x00062874 File Offset: 0x00060A74
			// Note: this type is marked as 'beforefieldinit'.
			static Table()
			{
				Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Table");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr);
				DebugUI.Table.NativeFieldInfoPtr_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr, "isReadOnly");
				DebugUI.Table.NativeFieldInfoPtr_m_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr, "m_Header");
				DebugUI.Table.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr, 100664337);
				DebugUI.Table.NativeMethodInfoPtr_SetColumnVisibility_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr, 100664338);
				DebugUI.Table.NativeMethodInfoPtr_GetColumnVisibility_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr, 100664339);
				DebugUI.Table.NativeMethodInfoPtr_get_VisibleColumns_Public_get_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr, 100664340);
				DebugUI.Table.NativeMethodInfoPtr_OnItemAdded_Protected_Virtual_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr, 100664341);
				DebugUI.Table.NativeMethodInfoPtr_OnItemRemoved_Protected_Virtual_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr, 100664342);
			}

			// Token: 0x060016ED RID: 5869 RVA: 0x00062940 File Offset: 0x00060B40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963901, XrefRangeEnd = 963905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Table()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Table.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016EE RID: 5870 RVA: 0x0006297C File Offset: 0x00060B7C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 963906, RefRangeEnd = 963907, XrefRangeStart = 963905, XrefRangeEnd = 963906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetColumnVisibility(int index, bool visible)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Table.NativeMethodInfoPtr_SetColumnVisibility_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016EF RID: 5871 RVA: 0x000629C8 File Offset: 0x00060BC8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 963908, RefRangeEnd = 963912, XrefRangeStart = 963907, XrefRangeEnd = 963908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool GetColumnVisibility(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Table.NativeMethodInfoPtr_GetColumnVisibility_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00062A14 File Offset: 0x00060C14
			public unsafe Il2CppStructArray<bool> VisibleColumns
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 963937, RefRangeEnd = 963939, XrefRangeStart = 963912, XrefRangeEnd = 963937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Table.NativeMethodInfoPtr_get_VisibleColumns_Public_get_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
				}
			}

			// Token: 0x060016F1 RID: 5873 RVA: 0x00062A54 File Offset: 0x00060C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963939, XrefRangeEnd = 963942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnItemAdded(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Table.NativeMethodInfoPtr_OnItemAdded_Protected_Virtual_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016F2 RID: 5874 RVA: 0x00062AB4 File Offset: 0x00060CB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963942, XrefRangeEnd = 963945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnItemRemoved(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Table.NativeMethodInfoPtr_OnItemRemoved_Protected_Virtual_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016F3 RID: 5875 RVA: 0x0000B79B File Offset: 0x0000999B
			public Table(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00062B14 File Offset: 0x00060D14
			// (set) Token: 0x060016F5 RID: 5877 RVA: 0x0000B7A4 File Offset: 0x000099A4
			public unsafe bool isReadOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Table.NativeFieldInfoPtr_isReadOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Table.NativeFieldInfoPtr_isReadOnly)) = value;
				}
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00062B3C File Offset: 0x00060D3C
			// (set) Token: 0x060016F7 RID: 5879 RVA: 0x0000B7BF File Offset: 0x000099BF
			public unsafe Il2CppStructArray<bool> m_Header
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Table.NativeFieldInfoPtr_m_Header);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Table.NativeFieldInfoPtr_m_Header), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010A9 RID: 4265
			private static readonly IntPtr NativeFieldInfoPtr_isReadOnly;

			// Token: 0x040010AA RID: 4266
			private static readonly IntPtr NativeFieldInfoPtr_m_Header;

			// Token: 0x040010AB RID: 4267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010AC RID: 4268
			private static readonly IntPtr NativeMethodInfoPtr_SetColumnVisibility_Public_Void_Int32_Boolean_0;

			// Token: 0x040010AD RID: 4269
			private static readonly IntPtr NativeMethodInfoPtr_GetColumnVisibility_Public_Boolean_Int32_0;

			// Token: 0x040010AE RID: 4270
			private static readonly IntPtr NativeMethodInfoPtr_get_VisibleColumns_Public_get_Il2CppStructArray_1_Boolean_0;

			// Token: 0x040010AF RID: 4271
			private static readonly IntPtr NativeMethodInfoPtr_OnItemAdded_Protected_Virtual_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0;

			// Token: 0x040010B0 RID: 4272
			private static readonly IntPtr NativeMethodInfoPtr_OnItemRemoved_Protected_Virtual_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0;

			// Token: 0x02000230 RID: 560
			public class Row : DebugUI.Foldout
			{
				// Token: 0x06001BDA RID: 7130 RVA: 0x0000DF57 File Offset: 0x0000C157
				// Note: this type is marked as 'beforefieldinit'.
				static Row()
				{
					Il2CppClassPointerStore<DebugUI.Table.Row>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI.Table>.NativeClassPtr, "Row");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Table.Row>.NativeClassPtr);
					DebugUI.Table.Row.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Table.Row>.NativeClassPtr, 100664343);
				}

				// Token: 0x06001BDB RID: 7131 RVA: 0x00070F20 File Offset: 0x0006F120
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963897, XrefRangeEnd = 963901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Row()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Table.Row>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Table.Row.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001BDC RID: 7132 RVA: 0x0000DF8B File Offset: 0x0000C18B
				public Row(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001426 RID: 5158
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x02000197 RID: 407
		[Flags]
		public enum Flags
		{
			// Token: 0x040010B2 RID: 4274
			None = 0,
			// Token: 0x040010B3 RID: 4275
			EditorOnly = 2,
			// Token: 0x040010B4 RID: 4276
			RuntimeOnly = 4,
			// Token: 0x040010B5 RID: 4277
			EditorForceUpdate = 8,
			// Token: 0x040010B6 RID: 4278
			FrequentlyUsed = 16
		}

		// Token: 0x02000198 RID: 408
		public class Widget : Object
		{
			// Token: 0x060016F8 RID: 5880 RVA: 0x00062B6C File Offset: 0x00060D6C
			// Note: this type is marked as 'beforefieldinit'.
			static Widget()
			{
				Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Widget");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr);
				DebugUI.Widget.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, "m_Panel");
				DebugUI.Widget.NativeFieldInfoPtr_m_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, "m_Parent");
				DebugUI.Widget.NativeFieldInfoPtr__flags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, "<flags>k__BackingField");
				DebugUI.Widget.NativeFieldInfoPtr__displayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, "<displayName>k__BackingField");
				DebugUI.Widget.NativeFieldInfoPtr__tooltip_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, "<tooltip>k__BackingField");
				DebugUI.Widget.NativeFieldInfoPtr__queryPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, "<queryPath>k__BackingField");
				DebugUI.Widget.NativeFieldInfoPtr_isHiddenCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, "isHiddenCallback");
				DebugUI.Widget.NativeMethodInfoPtr_get_panel_Public_Virtual_New_get_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664344);
				DebugUI.Widget.NativeMethodInfoPtr_set_panel_Internal_Virtual_New_set_Void_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664345);
				DebugUI.Widget.NativeMethodInfoPtr_get_parent_Public_Virtual_New_get_IContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664346);
				DebugUI.Widget.NativeMethodInfoPtr_set_parent_Internal_Virtual_New_set_Void_IContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664347);
				DebugUI.Widget.NativeMethodInfoPtr_get_flags_Public_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664348);
				DebugUI.Widget.NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664349);
				DebugUI.Widget.NativeMethodInfoPtr_get_displayName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664350);
				DebugUI.Widget.NativeMethodInfoPtr_set_displayName_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664351);
				DebugUI.Widget.NativeMethodInfoPtr_get_tooltip_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664352);
				DebugUI.Widget.NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664353);
				DebugUI.Widget.NativeMethodInfoPtr_get_queryPath_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664354);
				DebugUI.Widget.NativeMethodInfoPtr_set_queryPath_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664355);
				DebugUI.Widget.NativeMethodInfoPtr_get_isEditorOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664356);
				DebugUI.Widget.NativeMethodInfoPtr_get_isRuntimeOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664357);
				DebugUI.Widget.NativeMethodInfoPtr_get_isInactiveInEditor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664358);
				DebugUI.Widget.NativeMethodInfoPtr_get_isHidden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664359);
				DebugUI.Widget.NativeMethodInfoPtr_GenerateQueryPath_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664360);
				DebugUI.Widget.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664361);
				DebugUI.Widget.NativeMethodInfoPtr_set_nameAndTooltip_Public_set_Void_NameAndTooltip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664362);
				DebugUI.Widget.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, 100664363);
			}

			// Token: 0x17000667 RID: 1639
			// (get) Token: 0x060016F9 RID: 5881 RVA: 0x00062DB4 File Offset: 0x00060FB4
			// (set) Token: 0x060016FA RID: 5882 RVA: 0x00062E00 File Offset: 0x00061000
			public unsafe virtual DebugUI.Panel panel
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Widget.NativeMethodInfoPtr_get_panel_Public_Virtual_New_get_Panel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Panel>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Widget.NativeMethodInfoPtr_set_panel_Internal_Virtual_New_set_Void_Panel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000668 RID: 1640
			// (get) Token: 0x060016FB RID: 5883 RVA: 0x00062E50 File Offset: 0x00061050
			// (set) Token: 0x060016FC RID: 5884 RVA: 0x00062E9C File Offset: 0x0006109C
			public unsafe virtual DebugUI.IContainer parent
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Widget.NativeMethodInfoPtr_get_parent_Public_Virtual_New_get_IContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.IContainer>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Widget.NativeMethodInfoPtr_set_parent_Internal_Virtual_New_set_Void_IContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000669 RID: 1641
			// (get) Token: 0x060016FD RID: 5885 RVA: 0x00062EEC File Offset: 0x000610EC
			// (set) Token: 0x060016FE RID: 5886 RVA: 0x00062F28 File Offset: 0x00061128
			public unsafe DebugUI.Flags flags
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_get_flags_Public_get_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700066A RID: 1642
			// (get) Token: 0x060016FF RID: 5887 RVA: 0x00062F68 File Offset: 0x00061168
			// (set) Token: 0x06001700 RID: 5888 RVA: 0x00062FA0 File Offset: 0x000611A0
			public unsafe virtual string displayName
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_get_displayName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_set_displayName_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700066B RID: 1643
			// (get) Token: 0x06001701 RID: 5889 RVA: 0x00062FE4 File Offset: 0x000611E4
			// (set) Token: 0x06001702 RID: 5890 RVA: 0x0006301C File Offset: 0x0006121C
			public unsafe string tooltip
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_get_tooltip_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x06001703 RID: 5891 RVA: 0x00063060 File Offset: 0x00061260
			// (set) Token: 0x06001704 RID: 5892 RVA: 0x00063098 File Offset: 0x00061298
			public unsafe virtual string queryPath
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_get_queryPath_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_set_queryPath_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x06001705 RID: 5893 RVA: 0x000630DC File Offset: 0x000612DC
			public unsafe bool isEditorOnly
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 963945, RefRangeEnd = 963947, XrefRangeStart = 963945, XrefRangeEnd = 963945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_get_isEditorOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x06001706 RID: 5894 RVA: 0x00063118 File Offset: 0x00061318
			public unsafe bool isRuntimeOnly
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_get_isRuntimeOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x06001707 RID: 5895 RVA: 0x00063154 File Offset: 0x00061354
			public unsafe bool isInactiveInEditor
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963947, XrefRangeEnd = 963948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_get_isInactiveInEditor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000670 RID: 1648
			// (get) Token: 0x06001708 RID: 5896 RVA: 0x00063190 File Offset: 0x00061390
			public unsafe bool isHidden
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 963948, RefRangeEnd = 963949, XrefRangeStart = 963948, XrefRangeEnd = 963948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_get_isHidden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001709 RID: 5897 RVA: 0x000631CC File Offset: 0x000613CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963949, XrefRangeEnd = 963958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void GenerateQueryPath()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Widget.NativeMethodInfoPtr_GenerateQueryPath_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600170A RID: 5898 RVA: 0x00063208 File Offset: 0x00061408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963958, XrefRangeEnd = 963963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Widget.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000671 RID: 1649
			// (set) Token: 0x0600170B RID: 5899 RVA: 0x00063250 File Offset: 0x00061450
			public unsafe DebugUI.Widget.NameAndTooltip nameAndTooltip
			{
				[CallerCount(44)]
				[CachedScanResults(RefRangeStart = 963965, RefRangeEnd = 964009, XrefRangeStart = 963963, XrefRangeEnd = 963965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr_set_nameAndTooltip_Public_set_Void_NameAndTooltip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600170C RID: 5900 RVA: 0x00063298 File Offset: 0x00061498
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Widget()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Widget.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600170D RID: 5901 RVA: 0x0000B7DE File Offset: 0x000099DE
			public Widget(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x0600170E RID: 5902 RVA: 0x000632D4 File Offset: 0x000614D4
			// (set) Token: 0x0600170F RID: 5903 RVA: 0x0000B7E7 File Offset: 0x000099E7
			public unsafe DebugUI.Panel m_Panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr_m_Panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Panel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000661 RID: 1633
			// (get) Token: 0x06001710 RID: 5904 RVA: 0x00063304 File Offset: 0x00061504
			// (set) Token: 0x06001711 RID: 5905 RVA: 0x0000B806 File Offset: 0x00009A06
			public unsafe DebugUI.IContainer m_Parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr_m_Parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.IContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr_m_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x06001712 RID: 5906 RVA: 0x00063334 File Offset: 0x00061534
			// (set) Token: 0x06001713 RID: 5907 RVA: 0x0000B825 File Offset: 0x00009A25
			public unsafe DebugUI.Flags _flags_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr__flags_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr__flags_k__BackingField)) = value;
				}
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x06001714 RID: 5908 RVA: 0x0006335C File Offset: 0x0006155C
			// (set) Token: 0x06001715 RID: 5909 RVA: 0x0000B840 File Offset: 0x00009A40
			public unsafe string _displayName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr__displayName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr__displayName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x06001716 RID: 5910 RVA: 0x00063384 File Offset: 0x00061584
			// (set) Token: 0x06001717 RID: 5911 RVA: 0x0000B85F File Offset: 0x00009A5F
			public unsafe string _tooltip_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr__tooltip_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr__tooltip_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x06001718 RID: 5912 RVA: 0x000633AC File Offset: 0x000615AC
			// (set) Token: 0x06001719 RID: 5913 RVA: 0x0000B87E File Offset: 0x00009A7E
			public unsafe string _queryPath_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr__queryPath_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr__queryPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x0600171A RID: 5914 RVA: 0x000633D4 File Offset: 0x000615D4
			// (set) Token: 0x0600171B RID: 5915 RVA: 0x0000B89D File Offset: 0x00009A9D
			public unsafe Func<bool> isHiddenCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr_isHiddenCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NativeFieldInfoPtr_isHiddenCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010B7 RID: 4279
			private static readonly IntPtr NativeFieldInfoPtr_m_Panel;

			// Token: 0x040010B8 RID: 4280
			private static readonly IntPtr NativeFieldInfoPtr_m_Parent;

			// Token: 0x040010B9 RID: 4281
			private static readonly IntPtr NativeFieldInfoPtr__flags_k__BackingField;

			// Token: 0x040010BA RID: 4282
			private static readonly IntPtr NativeFieldInfoPtr__displayName_k__BackingField;

			// Token: 0x040010BB RID: 4283
			private static readonly IntPtr NativeFieldInfoPtr__tooltip_k__BackingField;

			// Token: 0x040010BC RID: 4284
			private static readonly IntPtr NativeFieldInfoPtr__queryPath_k__BackingField;

			// Token: 0x040010BD RID: 4285
			private static readonly IntPtr NativeFieldInfoPtr_isHiddenCallback;

			// Token: 0x040010BE RID: 4286
			private static readonly IntPtr NativeMethodInfoPtr_get_panel_Public_Virtual_New_get_Panel_0;

			// Token: 0x040010BF RID: 4287
			private static readonly IntPtr NativeMethodInfoPtr_set_panel_Internal_Virtual_New_set_Void_Panel_0;

			// Token: 0x040010C0 RID: 4288
			private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_Virtual_New_get_IContainer_0;

			// Token: 0x040010C1 RID: 4289
			private static readonly IntPtr NativeMethodInfoPtr_set_parent_Internal_Virtual_New_set_Void_IContainer_0;

			// Token: 0x040010C2 RID: 4290
			private static readonly IntPtr NativeMethodInfoPtr_get_flags_Public_get_Flags_0;

			// Token: 0x040010C3 RID: 4291
			private static readonly IntPtr NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0;

			// Token: 0x040010C4 RID: 4292
			private static readonly IntPtr NativeMethodInfoPtr_get_displayName_Public_Virtual_Final_New_get_String_0;

			// Token: 0x040010C5 RID: 4293
			private static readonly IntPtr NativeMethodInfoPtr_set_displayName_Public_Virtual_Final_New_set_Void_String_0;

			// Token: 0x040010C6 RID: 4294
			private static readonly IntPtr NativeMethodInfoPtr_get_tooltip_Public_get_String_0;

			// Token: 0x040010C7 RID: 4295
			private static readonly IntPtr NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0;

			// Token: 0x040010C8 RID: 4296
			private static readonly IntPtr NativeMethodInfoPtr_get_queryPath_Public_Virtual_Final_New_get_String_0;

			// Token: 0x040010C9 RID: 4297
			private static readonly IntPtr NativeMethodInfoPtr_set_queryPath_Private_set_Void_String_0;

			// Token: 0x040010CA RID: 4298
			private static readonly IntPtr NativeMethodInfoPtr_get_isEditorOnly_Public_get_Boolean_0;

			// Token: 0x040010CB RID: 4299
			private static readonly IntPtr NativeMethodInfoPtr_get_isRuntimeOnly_Public_get_Boolean_0;

			// Token: 0x040010CC RID: 4300
			private static readonly IntPtr NativeMethodInfoPtr_get_isInactiveInEditor_Public_get_Boolean_0;

			// Token: 0x040010CD RID: 4301
			private static readonly IntPtr NativeMethodInfoPtr_get_isHidden_Public_get_Boolean_0;

			// Token: 0x040010CE RID: 4302
			private static readonly IntPtr NativeMethodInfoPtr_GenerateQueryPath_Internal_Virtual_New_Void_0;

			// Token: 0x040010CF RID: 4303
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040010D0 RID: 4304
			private static readonly IntPtr NativeMethodInfoPtr_set_nameAndTooltip_Public_set_Void_NameAndTooltip_0;

			// Token: 0x040010D1 RID: 4305
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

			// Token: 0x02000231 RID: 561
			public sealed class NameAndTooltip : ValueType
			{
				// Token: 0x06001BDD RID: 7133 RVA: 0x00070F5C File Offset: 0x0006F15C
				// Note: this type is marked as 'beforefieldinit'.
				static NameAndTooltip()
				{
					Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI.Widget>.NativeClassPtr, "NameAndTooltip");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr);
					DebugUI.Widget.NameAndTooltip.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, "name");
					DebugUI.Widget.NameAndTooltip.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, "tooltip");
				}

				// Token: 0x06001BDE RID: 7134 RVA: 0x0000DF94 File Offset: 0x0000C194
				public NameAndTooltip(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001BDF RID: 7135 RVA: 0x0000DF9D File Offset: 0x0000C19D
				public NameAndTooltip()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr))
				{
				}

				// Token: 0x170007D4 RID: 2004
				// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00070FB0 File Offset: 0x0006F1B0
				// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0000DFAF File Offset: 0x0000C1AF
				public unsafe string name
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NameAndTooltip.NativeFieldInfoPtr_name);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NameAndTooltip.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170007D5 RID: 2005
				// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x00070FD8 File Offset: 0x0006F1D8
				// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x0000DFCE File Offset: 0x0000C1CE
				public unsafe string tooltip
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NameAndTooltip.NativeFieldInfoPtr_tooltip);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Widget.NameAndTooltip.NativeFieldInfoPtr_tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x04001427 RID: 5159
				private static readonly IntPtr NativeFieldInfoPtr_name;

				// Token: 0x04001428 RID: 5160
				private static readonly IntPtr NativeFieldInfoPtr_tooltip;
			}
		}

		// Token: 0x02000199 RID: 409
		public class IContainer : Il2CppObjectBase
		{
			// Token: 0x0600171C RID: 5916 RVA: 0x00063404 File Offset: 0x00061604
			// Note: this type is marked as 'beforefieldinit'.
			static IContainer()
			{
				Il2CppClassPointerStore<DebugUI.IContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "IContainer");
				DebugUI.IContainer.NativeMethodInfoPtr_get_children_Public_Abstract_Virtual_New_get_ObservableList_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.IContainer>.NativeClassPtr, 100664364);
				DebugUI.IContainer.NativeMethodInfoPtr_get_displayName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.IContainer>.NativeClassPtr, 100664365);
				DebugUI.IContainer.NativeMethodInfoPtr_set_displayName_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.IContainer>.NativeClassPtr, 100664366);
				DebugUI.IContainer.NativeMethodInfoPtr_get_queryPath_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.IContainer>.NativeClassPtr, 100664367);
			}

			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x0600171D RID: 5917 RVA: 0x00063478 File Offset: 0x00061678
			public unsafe virtual ObservableList<DebugUI.Widget> children
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.IContainer.NativeMethodInfoPtr_get_children_Public_Abstract_Virtual_New_get_ObservableList_1_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObservableList<DebugUI.Widget>>(intPtr3) : null;
				}
			}

			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x0600171E RID: 5918 RVA: 0x000634C4 File Offset: 0x000616C4
			// (set) Token: 0x0600171F RID: 5919 RVA: 0x00063508 File Offset: 0x00061708
			public unsafe virtual string displayName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.IContainer.NativeMethodInfoPtr_get_displayName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.IContainer.NativeMethodInfoPtr_set_displayName_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x06001720 RID: 5920 RVA: 0x00063558 File Offset: 0x00061758
			public unsafe virtual string queryPath
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.IContainer.NativeMethodInfoPtr_get_queryPath_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001721 RID: 5921 RVA: 0x0000B8BC File Offset: 0x00009ABC
			public IContainer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010D2 RID: 4306
			private static readonly IntPtr NativeMethodInfoPtr_get_children_Public_Abstract_Virtual_New_get_ObservableList_1_Widget_0;

			// Token: 0x040010D3 RID: 4307
			private static readonly IntPtr NativeMethodInfoPtr_get_displayName_Public_Abstract_Virtual_New_get_String_0;

			// Token: 0x040010D4 RID: 4308
			private static readonly IntPtr NativeMethodInfoPtr_set_displayName_Public_Abstract_Virtual_New_set_Void_String_0;

			// Token: 0x040010D5 RID: 4309
			private static readonly IntPtr NativeMethodInfoPtr_get_queryPath_Public_Abstract_Virtual_New_get_String_0;
		}

		// Token: 0x0200019A RID: 410
		public class IValueField : Il2CppObjectBase
		{
			// Token: 0x06001722 RID: 5922 RVA: 0x0006359C File Offset: 0x0006179C
			// Note: this type is marked as 'beforefieldinit'.
			static IValueField()
			{
				Il2CppClassPointerStore<DebugUI.IValueField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "IValueField");
				DebugUI.IValueField.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.IValueField>.NativeClassPtr, 100664368);
				DebugUI.IValueField.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.IValueField>.NativeClassPtr, 100664369);
				DebugUI.IValueField.NativeMethodInfoPtr_ValidateValue_Public_Abstract_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.IValueField>.NativeClassPtr, 100664370);
			}

			// Token: 0x06001723 RID: 5923 RVA: 0x000635FC File Offset: 0x000617FC
			[CallerCount(0)]
			public unsafe virtual Object GetValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.IValueField.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06001724 RID: 5924 RVA: 0x00063648 File Offset: 0x00061848
			[CallerCount(0)]
			public unsafe virtual void SetValue(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.IValueField.NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001725 RID: 5925 RVA: 0x00063698 File Offset: 0x00061898
			[CallerCount(0)]
			public unsafe virtual Object ValidateValue(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.IValueField.NativeMethodInfoPtr_ValidateValue_Public_Abstract_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001726 RID: 5926 RVA: 0x0000B8C5 File Offset: 0x00009AC5
			public IValueField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010D6 RID: 4310
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0;

			// Token: 0x040010D7 RID: 4311
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Abstract_Virtual_New_Void_Object_0;

			// Token: 0x040010D8 RID: 4312
			private static readonly IntPtr NativeMethodInfoPtr_ValidateValue_Public_Abstract_Virtual_New_Object_Object_0;
		}

		// Token: 0x0200019B RID: 411
		public class Button : DebugUI.Widget
		{
			// Token: 0x06001727 RID: 5927 RVA: 0x000636F4 File Offset: 0x000618F4
			// Note: this type is marked as 'beforefieldinit'.
			static Button()
			{
				Il2CppClassPointerStore<DebugUI.Button>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Button");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Button>.NativeClassPtr);
				DebugUI.Button.NativeFieldInfoPtr__action_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Button>.NativeClassPtr, "<action>k__BackingField");
				DebugUI.Button.NativeMethodInfoPtr_get_action_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Button>.NativeClassPtr, 100664371);
				DebugUI.Button.NativeMethodInfoPtr_set_action_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Button>.NativeClassPtr, 100664372);
				DebugUI.Button.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Button>.NativeClassPtr, 100664373);
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x06001728 RID: 5928 RVA: 0x00063770 File Offset: 0x00061970
			// (set) Token: 0x06001729 RID: 5929 RVA: 0x000637B0 File Offset: 0x000619B0
			public unsafe Action action
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Button.NativeMethodInfoPtr_get_action_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Button.NativeMethodInfoPtr_set_action_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600172A RID: 5930 RVA: 0x000637F4 File Offset: 0x000619F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Button()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Button>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Button.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600172B RID: 5931 RVA: 0x0000B8CE File Offset: 0x00009ACE
			public Button(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x0600172C RID: 5932 RVA: 0x00063830 File Offset: 0x00061A30
			// (set) Token: 0x0600172D RID: 5933 RVA: 0x0000B8D7 File Offset: 0x00009AD7
			public unsafe Action _action_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Button.NativeFieldInfoPtr__action_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Button.NativeFieldInfoPtr__action_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010D9 RID: 4313
			private static readonly IntPtr NativeFieldInfoPtr__action_k__BackingField;

			// Token: 0x040010DA RID: 4314
			private static readonly IntPtr NativeMethodInfoPtr_get_action_Public_get_Action_0;

			// Token: 0x040010DB RID: 4315
			private static readonly IntPtr NativeMethodInfoPtr_set_action_Public_set_Void_Action_0;

			// Token: 0x040010DC RID: 4316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200019C RID: 412
		public class Value : DebugUI.Widget
		{
			// Token: 0x0600172E RID: 5934 RVA: 0x00063860 File Offset: 0x00061A60
			// Note: this type is marked as 'beforefieldinit'.
			static Value()
			{
				Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Value");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr);
				DebugUI.Value.NativeFieldInfoPtr__getter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr, "<getter>k__BackingField");
				DebugUI.Value.NativeFieldInfoPtr_refreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr, "refreshRate");
				DebugUI.Value.NativeFieldInfoPtr_formatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr, "formatString");
				DebugUI.Value.NativeMethodInfoPtr_get_getter_Public_get_Func_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr, 100664374);
				DebugUI.Value.NativeMethodInfoPtr_set_getter_Public_set_Void_Func_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr, 100664375);
				DebugUI.Value.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr, 100664376);
				DebugUI.Value.NativeMethodInfoPtr_GetValue_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr, 100664377);
				DebugUI.Value.NativeMethodInfoPtr_FormatString_Public_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr, 100664378);
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x0600172F RID: 5935 RVA: 0x0006392C File Offset: 0x00061B2C
			// (set) Token: 0x06001730 RID: 5936 RVA: 0x0006396C File Offset: 0x00061B6C
			public unsafe Func<Object> getter
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Value.NativeMethodInfoPtr_get_getter_Public_get_Func_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Value.NativeMethodInfoPtr_set_getter_Public_set_Void_Func_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001731 RID: 5937 RVA: 0x000639B0 File Offset: 0x00061BB0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 964013, RefRangeEnd = 964015, XrefRangeStart = 964009, XrefRangeEnd = 964013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Value()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Value>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Value.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001732 RID: 5938 RVA: 0x000639EC File Offset: 0x00061BEC
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 964017, RefRangeEnd = 964033, XrefRangeStart = 964015, XrefRangeEnd = 964017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object GetValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Value.NativeMethodInfoPtr_GetValue_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06001733 RID: 5939 RVA: 0x00063A38 File Offset: 0x00061C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964033, XrefRangeEnd = 964037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string FormatString(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Value.NativeMethodInfoPtr_FormatString_Public_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001734 RID: 5940 RVA: 0x0000B8F6 File Offset: 0x00009AF6
			public Value(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x06001735 RID: 5941 RVA: 0x00063A8C File Offset: 0x00061C8C
			// (set) Token: 0x06001736 RID: 5942 RVA: 0x0000B8FF File Offset: 0x00009AFF
			public unsafe Func<Object> _getter_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Value.NativeFieldInfoPtr__getter_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Value.NativeFieldInfoPtr__getter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x06001737 RID: 5943 RVA: 0x00063ABC File Offset: 0x00061CBC
			// (set) Token: 0x06001738 RID: 5944 RVA: 0x0000B91E File Offset: 0x00009B1E
			public unsafe float refreshRate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Value.NativeFieldInfoPtr_refreshRate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Value.NativeFieldInfoPtr_refreshRate)) = value;
				}
			}

			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x06001739 RID: 5945 RVA: 0x00063AE4 File Offset: 0x00061CE4
			// (set) Token: 0x0600173A RID: 5946 RVA: 0x0000B939 File Offset: 0x00009B39
			public unsafe string formatString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Value.NativeFieldInfoPtr_formatString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Value.NativeFieldInfoPtr_formatString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040010DD RID: 4317
			private static readonly IntPtr NativeFieldInfoPtr__getter_k__BackingField;

			// Token: 0x040010DE RID: 4318
			private static readonly IntPtr NativeFieldInfoPtr_refreshRate;

			// Token: 0x040010DF RID: 4319
			private static readonly IntPtr NativeFieldInfoPtr_formatString;

			// Token: 0x040010E0 RID: 4320
			private static readonly IntPtr NativeMethodInfoPtr_get_getter_Public_get_Func_1_Object_0;

			// Token: 0x040010E1 RID: 4321
			private static readonly IntPtr NativeMethodInfoPtr_set_getter_Public_set_Void_Func_1_Object_0;

			// Token: 0x040010E2 RID: 4322
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010E3 RID: 4323
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_New_Object_0;

			// Token: 0x040010E4 RID: 4324
			private static readonly IntPtr NativeMethodInfoPtr_FormatString_Public_Virtual_New_String_Object_0;
		}

		// Token: 0x0200019D RID: 413
		public class ProgressBarValue : DebugUI.Value
		{
			// Token: 0x0600173B RID: 5947 RVA: 0x00063B0C File Offset: 0x00061D0C
			// Note: this type is marked as 'beforefieldinit'.
			static ProgressBarValue()
			{
				Il2CppClassPointerStore<DebugUI.ProgressBarValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "ProgressBarValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.ProgressBarValue>.NativeClassPtr);
				DebugUI.ProgressBarValue.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ProgressBarValue>.NativeClassPtr, "min");
				DebugUI.ProgressBarValue.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ProgressBarValue>.NativeClassPtr, "max");
				DebugUI.ProgressBarValue.NativeMethodInfoPtr_FormatString_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ProgressBarValue>.NativeClassPtr, 100664379);
				DebugUI.ProgressBarValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ProgressBarValue>.NativeClassPtr, 100664380);
				DebugUI.ProgressBarValue.NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ProgressBarValue>.NativeClassPtr, 100664381);
			}

			// Token: 0x0600173C RID: 5948 RVA: 0x00063B9C File Offset: 0x00061D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964037, XrefRangeEnd = 964046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string FormatString(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.ProgressBarValue.NativeMethodInfoPtr_FormatString_Public_Virtual_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600173D RID: 5949 RVA: 0x00063BF0 File Offset: 0x00061DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964046, XrefRangeEnd = 964050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProgressBarValue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.ProgressBarValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ProgressBarValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600173E RID: 5950 RVA: 0x00063C2C File Offset: 0x00061E2C
			[CallerCount(0)]
			public unsafe static float Method_Internal_Static_Single_Single_Single_Single_PDM_0(float v, float x0, float y0)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x0;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ProgressBarValue.NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600173F RID: 5951 RVA: 0x0000B958 File Offset: 0x00009B58
			public ProgressBarValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700067B RID: 1659
			// (get) Token: 0x06001740 RID: 5952 RVA: 0x00063C88 File Offset: 0x00061E88
			// (set) Token: 0x06001741 RID: 5953 RVA: 0x0000B961 File Offset: 0x00009B61
			public unsafe float min
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ProgressBarValue.NativeFieldInfoPtr_min);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ProgressBarValue.NativeFieldInfoPtr_min)) = value;
				}
			}

			// Token: 0x1700067C RID: 1660
			// (get) Token: 0x06001742 RID: 5954 RVA: 0x00063CB0 File Offset: 0x00061EB0
			// (set) Token: 0x06001743 RID: 5955 RVA: 0x0000B97C File Offset: 0x00009B7C
			public unsafe float max
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ProgressBarValue.NativeFieldInfoPtr_max);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ProgressBarValue.NativeFieldInfoPtr_max)) = value;
				}
			}

			// Token: 0x040010E5 RID: 4325
			private static readonly IntPtr NativeFieldInfoPtr_min;

			// Token: 0x040010E6 RID: 4326
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x040010E7 RID: 4327
			private static readonly IntPtr NativeMethodInfoPtr_FormatString_Public_Virtual_String_Object_0;

			// Token: 0x040010E8 RID: 4328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010E9 RID: 4329
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_Single_PDM_0;
		}

		// Token: 0x0200019E RID: 414
		public class ValueTuple : DebugUI.Widget
		{
			// Token: 0x06001744 RID: 5956 RVA: 0x00063CD8 File Offset: 0x00061ED8
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTuple()
			{
				Il2CppClassPointerStore<DebugUI.ValueTuple>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "ValueTuple");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.ValueTuple>.NativeClassPtr);
				DebugUI.ValueTuple.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ValueTuple>.NativeClassPtr, "values");
				DebugUI.ValueTuple.NativeFieldInfoPtr_pinnedElementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ValueTuple>.NativeClassPtr, "pinnedElementIndex");
				DebugUI.ValueTuple.NativeMethodInfoPtr_get_numElements_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ValueTuple>.NativeClassPtr, 100664382);
				DebugUI.ValueTuple.NativeMethodInfoPtr_get_refreshRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ValueTuple>.NativeClassPtr, 100664383);
				DebugUI.ValueTuple.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ValueTuple>.NativeClassPtr, 100664384);
			}

			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x06001745 RID: 5957 RVA: 0x00063D68 File Offset: 0x00061F68
			public unsafe int numElements
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 964050, RefRangeEnd = 964053, XrefRangeStart = 964050, XrefRangeEnd = 964050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ValueTuple.NativeMethodInfoPtr_get_numElements_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x06001746 RID: 5958 RVA: 0x00063DA4 File Offset: 0x00061FA4
			public unsafe float refreshRate
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 964056, RefRangeEnd = 964058, XrefRangeStart = 964053, XrefRangeEnd = 964056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ValueTuple.NativeMethodInfoPtr_get_refreshRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001747 RID: 5959 RVA: 0x00063DE0 File Offset: 0x00061FE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964058, XrefRangeEnd = 964059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.ValueTuple>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ValueTuple.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001748 RID: 5960 RVA: 0x0000B997 File Offset: 0x00009B97
			public ValueTuple(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700067D RID: 1661
			// (get) Token: 0x06001749 RID: 5961 RVA: 0x00063E1C File Offset: 0x0006201C
			// (set) Token: 0x0600174A RID: 5962 RVA: 0x0000B9A0 File Offset: 0x00009BA0
			public unsafe Il2CppReferenceArray<DebugUI.Value> values
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ValueTuple.NativeFieldInfoPtr_values);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugUI.Value>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ValueTuple.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700067E RID: 1662
			// (get) Token: 0x0600174B RID: 5963 RVA: 0x00063E4C File Offset: 0x0006204C
			// (set) Token: 0x0600174C RID: 5964 RVA: 0x0000B9BF File Offset: 0x00009BBF
			public unsafe int pinnedElementIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ValueTuple.NativeFieldInfoPtr_pinnedElementIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ValueTuple.NativeFieldInfoPtr_pinnedElementIndex)) = value;
				}
			}

			// Token: 0x040010EA RID: 4330
			private static readonly IntPtr NativeFieldInfoPtr_values;

			// Token: 0x040010EB RID: 4331
			private static readonly IntPtr NativeFieldInfoPtr_pinnedElementIndex;

			// Token: 0x040010EC RID: 4332
			private static readonly IntPtr NativeMethodInfoPtr_get_numElements_Public_get_Int32_0;

			// Token: 0x040010ED RID: 4333
			private static readonly IntPtr NativeMethodInfoPtr_get_refreshRate_Public_get_Single_0;

			// Token: 0x040010EE RID: 4334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200019F RID: 415
		public class Field<T> : DebugUI.Widget
		{
			// Token: 0x0600174D RID: 5965 RVA: 0x00063E74 File Offset: 0x00062074
			// Note: this type is marked as 'beforefieldinit'.
			static Field()
			{
				Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Field`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr);
				DebugUI.Field<T>.NativeFieldInfoPtr__getter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, "<getter>k__BackingField");
				DebugUI.Field<T>.NativeFieldInfoPtr__setter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, "<setter>k__BackingField");
				DebugUI.Field<T>.NativeFieldInfoPtr_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, "onValueChanged");
				DebugUI.Field<T>.NativeMethodInfoPtr_get_getter_Public_get_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664385);
				DebugUI.Field<T>.NativeMethodInfoPtr_set_getter_Public_set_Void_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664386);
				DebugUI.Field<T>.NativeMethodInfoPtr_get_setter_Public_get_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664387);
				DebugUI.Field<T>.NativeMethodInfoPtr_set_setter_Public_set_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664388);
				DebugUI.Field<T>.NativeMethodInfoPtr_UnityEngine_Rendering_DebugUI_IValueField_ValidateValue_Private_Virtual_Final_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664389);
				DebugUI.Field<T>.NativeMethodInfoPtr_ValidateValue_Public_Virtual_New_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664390);
				DebugUI.Field<T>.NativeMethodInfoPtr_UnityEngine_Rendering_DebugUI_IValueField_GetValue_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664391);
				DebugUI.Field<T>.NativeMethodInfoPtr_GetValue_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664392);
				DebugUI.Field<T>.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664393);
				DebugUI.Field<T>.NativeMethodInfoPtr_SetValue_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664394);
				DebugUI.Field<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr, 100664395);
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x0600174E RID: 5966 RVA: 0x00063FF4 File Offset: 0x000621F4
			// (set) Token: 0x0600174F RID: 5967 RVA: 0x00064034 File Offset: 0x00062234
			public unsafe Func<T> getter
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Field<T>.NativeMethodInfoPtr_get_getter_Public_get_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Field<T>.NativeMethodInfoPtr_set_getter_Public_set_Void_Func_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x06001750 RID: 5968 RVA: 0x00064078 File Offset: 0x00062278
			// (set) Token: 0x06001751 RID: 5969 RVA: 0x000640B8 File Offset: 0x000622B8
			public unsafe Action<T> setter
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Field<T>.NativeMethodInfoPtr_get_setter_Public_get_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Field<T>.NativeMethodInfoPtr_set_setter_Public_set_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001752 RID: 5970 RVA: 0x000640FC File Offset: 0x000622FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964059, XrefRangeEnd = 964062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object UnityEngine_Rendering_DebugUI_IValueField_ValidateValue(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Field<T>.NativeMethodInfoPtr_UnityEngine_Rendering_DebugUI_IValueField_ValidateValue_Private_Virtual_Final_New_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001753 RID: 5971 RVA: 0x0006414C File Offset: 0x0006234C
			[CallerCount(0)]
			public unsafe virtual T ValidateValue(T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Field<T>.NativeMethodInfoPtr_ValidateValue_Public_Virtual_New_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
				}
			}

			// Token: 0x06001754 RID: 5972 RVA: 0x000641D8 File Offset: 0x000623D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964062, XrefRangeEnd = 964063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object UnityEngine_Rendering_DebugUI_IValueField_GetValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Field<T>.NativeMethodInfoPtr_UnityEngine_Rendering_DebugUI_IValueField_GetValue_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06001755 RID: 5973 RVA: 0x00064218 File Offset: 0x00062418
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 964017, RefRangeEnd = 964033, XrefRangeStart = 964017, XrefRangeEnd = 964033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T GetValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Field<T>.NativeMethodInfoPtr_GetValue_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06001756 RID: 5974 RVA: 0x00064254 File Offset: 0x00062454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964063, XrefRangeEnd = 964072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetValue(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Field<T>.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001757 RID: 5975 RVA: 0x00064298 File Offset: 0x00062498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964072, XrefRangeEnd = 964077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void SetValue(T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Field<T>.NativeMethodInfoPtr_SetValue_Public_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06001758 RID: 5976 RVA: 0x0006431C File Offset: 0x0006251C
			[CallerCount(220)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Field()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Field<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Field<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001759 RID: 5977 RVA: 0x0000B9DA File Offset: 0x00009BDA
			public Field(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x0600175A RID: 5978 RVA: 0x00064358 File Offset: 0x00062558
			// (set) Token: 0x0600175B RID: 5979 RVA: 0x0000B9E3 File Offset: 0x00009BE3
			public unsafe Func<T> _getter_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Field<T>.NativeFieldInfoPtr__getter_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Field<T>.NativeFieldInfoPtr__getter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x0600175C RID: 5980 RVA: 0x00064388 File Offset: 0x00062588
			// (set) Token: 0x0600175D RID: 5981 RVA: 0x0000BA02 File Offset: 0x00009C02
			public unsafe Action<T> _setter_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Field<T>.NativeFieldInfoPtr__setter_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Field<T>.NativeFieldInfoPtr__setter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x0600175E RID: 5982 RVA: 0x000643B8 File Offset: 0x000625B8
			// (set) Token: 0x0600175F RID: 5983 RVA: 0x0000BA21 File Offset: 0x00009C21
			public unsafe Action<DebugUI.Field<T>, T> onValueChanged
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Field<T>.NativeFieldInfoPtr_onValueChanged);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DebugUI.Field<T>, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Field<T>.NativeFieldInfoPtr_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010EF RID: 4335
			private static readonly IntPtr NativeFieldInfoPtr__getter_k__BackingField;

			// Token: 0x040010F0 RID: 4336
			private static readonly IntPtr NativeFieldInfoPtr__setter_k__BackingField;

			// Token: 0x040010F1 RID: 4337
			private static readonly IntPtr NativeFieldInfoPtr_onValueChanged;

			// Token: 0x040010F2 RID: 4338
			private static readonly IntPtr NativeMethodInfoPtr_get_getter_Public_get_Func_1_T_0;

			// Token: 0x040010F3 RID: 4339
			private static readonly IntPtr NativeMethodInfoPtr_set_getter_Public_set_Void_Func_1_T_0;

			// Token: 0x040010F4 RID: 4340
			private static readonly IntPtr NativeMethodInfoPtr_get_setter_Public_get_Action_1_T_0;

			// Token: 0x040010F5 RID: 4341
			private static readonly IntPtr NativeMethodInfoPtr_set_setter_Public_set_Void_Action_1_T_0;

			// Token: 0x040010F6 RID: 4342
			private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Rendering_DebugUI_IValueField_ValidateValue_Private_Virtual_Final_New_Object_Object_0;

			// Token: 0x040010F7 RID: 4343
			private static readonly IntPtr NativeMethodInfoPtr_ValidateValue_Public_Virtual_New_T_T_0;

			// Token: 0x040010F8 RID: 4344
			private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Rendering_DebugUI_IValueField_GetValue_Private_Virtual_Final_New_Object_0;

			// Token: 0x040010F9 RID: 4345
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_T_0;

			// Token: 0x040010FA RID: 4346
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_Object_0;

			// Token: 0x040010FB RID: 4347
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_New_Void_T_0;

			// Token: 0x040010FC RID: 4348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x020001A0 RID: 416
		public class BoolField : DebugUI.Field<bool>
		{
			// Token: 0x06001760 RID: 5984 RVA: 0x0000BA40 File Offset: 0x00009C40
			// Note: this type is marked as 'beforefieldinit'.
			static BoolField()
			{
				Il2CppClassPointerStore<DebugUI.BoolField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "BoolField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.BoolField>.NativeClassPtr);
				DebugUI.BoolField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.BoolField>.NativeClassPtr, 100664396);
			}

			// Token: 0x06001761 RID: 5985 RVA: 0x000643E8 File Offset: 0x000625E8
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 964080, RefRangeEnd = 964093, XrefRangeStart = 964077, XrefRangeEnd = 964080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoolField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.BoolField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.BoolField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001762 RID: 5986 RVA: 0x0000BA74 File Offset: 0x00009C74
			public BoolField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040010FD RID: 4349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A1 RID: 417
		public class HistoryBoolField : DebugUI.BoolField
		{
			// Token: 0x06001763 RID: 5987 RVA: 0x00064424 File Offset: 0x00062624
			// Note: this type is marked as 'beforefieldinit'.
			static HistoryBoolField()
			{
				Il2CppClassPointerStore<DebugUI.HistoryBoolField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "HistoryBoolField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.HistoryBoolField>.NativeClassPtr);
				DebugUI.HistoryBoolField.NativeFieldInfoPtr__historyGetter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.HistoryBoolField>.NativeClassPtr, "<historyGetter>k__BackingField");
				DebugUI.HistoryBoolField.NativeMethodInfoPtr_get_historyGetter_Public_get_Il2CppReferenceArray_1_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HistoryBoolField>.NativeClassPtr, 100664397);
				DebugUI.HistoryBoolField.NativeMethodInfoPtr_set_historyGetter_Public_set_Void_Il2CppReferenceArray_1_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HistoryBoolField>.NativeClassPtr, 100664398);
				DebugUI.HistoryBoolField.NativeMethodInfoPtr_get_historyDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HistoryBoolField>.NativeClassPtr, 100664399);
				DebugUI.HistoryBoolField.NativeMethodInfoPtr_GetHistoryValue_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HistoryBoolField>.NativeClassPtr, 100664400);
				DebugUI.HistoryBoolField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HistoryBoolField>.NativeClassPtr, 100664401);
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x06001764 RID: 5988 RVA: 0x000644C8 File Offset: 0x000626C8
			// (set) Token: 0x06001765 RID: 5989 RVA: 0x00064508 File Offset: 0x00062708
			public unsafe Il2CppReferenceArray<Func<bool>> historyGetter
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HistoryBoolField.NativeMethodInfoPtr_get_historyGetter_Public_get_Il2CppReferenceArray_1_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Func<bool>>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HistoryBoolField.NativeMethodInfoPtr_set_historyGetter_Public_set_Void_Il2CppReferenceArray_1_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x06001766 RID: 5990 RVA: 0x0006454C File Offset: 0x0006274C
			public unsafe int historyDepth
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 964093, RefRangeEnd = 964095, XrefRangeStart = 964093, XrefRangeEnd = 964093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HistoryBoolField.NativeMethodInfoPtr_get_historyDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001767 RID: 5991 RVA: 0x00064588 File Offset: 0x00062788
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 964097, RefRangeEnd = 964098, XrefRangeStart = 964095, XrefRangeEnd = 964097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool GetHistoryValue(int historyIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref historyIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HistoryBoolField.NativeMethodInfoPtr_GetHistoryValue_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001768 RID: 5992 RVA: 0x000645D4 File Offset: 0x000627D4
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 964080, RefRangeEnd = 964093, XrefRangeStart = 964080, XrefRangeEnd = 964093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HistoryBoolField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.HistoryBoolField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HistoryBoolField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001769 RID: 5993 RVA: 0x0000BA7D File Offset: 0x00009C7D
			public HistoryBoolField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000686 RID: 1670
			// (get) Token: 0x0600176A RID: 5994 RVA: 0x00064610 File Offset: 0x00062810
			// (set) Token: 0x0600176B RID: 5995 RVA: 0x0000BA86 File Offset: 0x00009C86
			public unsafe Il2CppReferenceArray<Func<bool>> _historyGetter_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.HistoryBoolField.NativeFieldInfoPtr__historyGetter_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Func<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.HistoryBoolField.NativeFieldInfoPtr__historyGetter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010FE RID: 4350
			private static readonly IntPtr NativeFieldInfoPtr__historyGetter_k__BackingField;

			// Token: 0x040010FF RID: 4351
			private static readonly IntPtr NativeMethodInfoPtr_get_historyGetter_Public_get_Il2CppReferenceArray_1_Func_1_Boolean_0;

			// Token: 0x04001100 RID: 4352
			private static readonly IntPtr NativeMethodInfoPtr_set_historyGetter_Public_set_Void_Il2CppReferenceArray_1_Func_1_Boolean_0;

			// Token: 0x04001101 RID: 4353
			private static readonly IntPtr NativeMethodInfoPtr_get_historyDepth_Public_get_Int32_0;

			// Token: 0x04001102 RID: 4354
			private static readonly IntPtr NativeMethodInfoPtr_GetHistoryValue_Public_Boolean_Int32_0;

			// Token: 0x04001103 RID: 4355
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A2 RID: 418
		public class IntField : DebugUI.Field<int>
		{
			// Token: 0x0600176C RID: 5996 RVA: 0x00064640 File Offset: 0x00062840
			// Note: this type is marked as 'beforefieldinit'.
			static IntField()
			{
				Il2CppClassPointerStore<DebugUI.IntField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "IntField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.IntField>.NativeClassPtr);
				DebugUI.IntField.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.IntField>.NativeClassPtr, "min");
				DebugUI.IntField.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.IntField>.NativeClassPtr, "max");
				DebugUI.IntField.NativeFieldInfoPtr_incStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.IntField>.NativeClassPtr, "incStep");
				DebugUI.IntField.NativeFieldInfoPtr_intStepMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.IntField>.NativeClassPtr, "intStepMult");
				DebugUI.IntField.NativeMethodInfoPtr_ValidateValue_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.IntField>.NativeClassPtr, 100664402);
				DebugUI.IntField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.IntField>.NativeClassPtr, 100664403);
			}

			// Token: 0x0600176D RID: 5997 RVA: 0x000646E4 File Offset: 0x000628E4
			[CallerCount(0)]
			public unsafe override int ValidateValue(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.IntField.NativeMethodInfoPtr_ValidateValue_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600176E RID: 5998 RVA: 0x00064738 File Offset: 0x00062938
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 964101, RefRangeEnd = 964107, XrefRangeStart = 964098, XrefRangeEnd = 964101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.IntField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.IntField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600176F RID: 5999 RVA: 0x0000BAA5 File Offset: 0x00009CA5
			public IntField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x06001770 RID: 6000 RVA: 0x00064774 File Offset: 0x00062974
			// (set) Token: 0x06001771 RID: 6001 RVA: 0x0000BAAE File Offset: 0x00009CAE
			public unsafe Func<int> min
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.IntField.NativeFieldInfoPtr_min);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.IntField.NativeFieldInfoPtr_min), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x06001772 RID: 6002 RVA: 0x000647A4 File Offset: 0x000629A4
			// (set) Token: 0x06001773 RID: 6003 RVA: 0x0000BACD File Offset: 0x00009CCD
			public unsafe Func<int> max
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.IntField.NativeFieldInfoPtr_max);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.IntField.NativeFieldInfoPtr_max), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x06001774 RID: 6004 RVA: 0x000647D4 File Offset: 0x000629D4
			// (set) Token: 0x06001775 RID: 6005 RVA: 0x0000BAEC File Offset: 0x00009CEC
			public unsafe int incStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.IntField.NativeFieldInfoPtr_incStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.IntField.NativeFieldInfoPtr_incStep)) = value;
				}
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x06001776 RID: 6006 RVA: 0x000647FC File Offset: 0x000629FC
			// (set) Token: 0x06001777 RID: 6007 RVA: 0x0000BB07 File Offset: 0x00009D07
			public unsafe int intStepMult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.IntField.NativeFieldInfoPtr_intStepMult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.IntField.NativeFieldInfoPtr_intStepMult)) = value;
				}
			}

			// Token: 0x04001104 RID: 4356
			private static readonly IntPtr NativeFieldInfoPtr_min;

			// Token: 0x04001105 RID: 4357
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x04001106 RID: 4358
			private static readonly IntPtr NativeFieldInfoPtr_incStep;

			// Token: 0x04001107 RID: 4359
			private static readonly IntPtr NativeFieldInfoPtr_intStepMult;

			// Token: 0x04001108 RID: 4360
			private static readonly IntPtr NativeMethodInfoPtr_ValidateValue_Public_Virtual_Int32_Int32_0;

			// Token: 0x04001109 RID: 4361
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A3 RID: 419
		public class UIntField : DebugUI.Field<uint>
		{
			// Token: 0x06001778 RID: 6008 RVA: 0x00064824 File Offset: 0x00062A24
			// Note: this type is marked as 'beforefieldinit'.
			static UIntField()
			{
				Il2CppClassPointerStore<DebugUI.UIntField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "UIntField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.UIntField>.NativeClassPtr);
				DebugUI.UIntField.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.UIntField>.NativeClassPtr, "min");
				DebugUI.UIntField.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.UIntField>.NativeClassPtr, "max");
				DebugUI.UIntField.NativeFieldInfoPtr_incStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.UIntField>.NativeClassPtr, "incStep");
				DebugUI.UIntField.NativeFieldInfoPtr_intStepMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.UIntField>.NativeClassPtr, "intStepMult");
				DebugUI.UIntField.NativeMethodInfoPtr_ValidateValue_Public_Virtual_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.UIntField>.NativeClassPtr, 100664404);
				DebugUI.UIntField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.UIntField>.NativeClassPtr, 100664405);
			}

			// Token: 0x06001779 RID: 6009 RVA: 0x000648C8 File Offset: 0x00062AC8
			[CallerCount(0)]
			public unsafe override uint ValidateValue(uint value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.UIntField.NativeMethodInfoPtr_ValidateValue_Public_Virtual_UInt32_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600177A RID: 6010 RVA: 0x0006491C File Offset: 0x00062B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964107, XrefRangeEnd = 964110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIntField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.UIntField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.UIntField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600177B RID: 6011 RVA: 0x0000BB22 File Offset: 0x00009D22
			public UIntField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x0600177C RID: 6012 RVA: 0x00064958 File Offset: 0x00062B58
			// (set) Token: 0x0600177D RID: 6013 RVA: 0x0000BB2B File Offset: 0x00009D2B
			public unsafe Func<uint> min
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.UIntField.NativeFieldInfoPtr_min);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<uint>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.UIntField.NativeFieldInfoPtr_min), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x0600177E RID: 6014 RVA: 0x00064988 File Offset: 0x00062B88
			// (set) Token: 0x0600177F RID: 6015 RVA: 0x0000BB4A File Offset: 0x00009D4A
			public unsafe Func<uint> max
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.UIntField.NativeFieldInfoPtr_max);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<uint>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.UIntField.NativeFieldInfoPtr_max), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x06001780 RID: 6016 RVA: 0x000649B8 File Offset: 0x00062BB8
			// (set) Token: 0x06001781 RID: 6017 RVA: 0x0000BB69 File Offset: 0x00009D69
			public unsafe uint incStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.UIntField.NativeFieldInfoPtr_incStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.UIntField.NativeFieldInfoPtr_incStep)) = value;
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x06001782 RID: 6018 RVA: 0x000649E0 File Offset: 0x00062BE0
			// (set) Token: 0x06001783 RID: 6019 RVA: 0x0000BB84 File Offset: 0x00009D84
			public unsafe uint intStepMult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.UIntField.NativeFieldInfoPtr_intStepMult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.UIntField.NativeFieldInfoPtr_intStepMult)) = value;
				}
			}

			// Token: 0x0400110A RID: 4362
			private static readonly IntPtr NativeFieldInfoPtr_min;

			// Token: 0x0400110B RID: 4363
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x0400110C RID: 4364
			private static readonly IntPtr NativeFieldInfoPtr_incStep;

			// Token: 0x0400110D RID: 4365
			private static readonly IntPtr NativeFieldInfoPtr_intStepMult;

			// Token: 0x0400110E RID: 4366
			private static readonly IntPtr NativeMethodInfoPtr_ValidateValue_Public_Virtual_UInt32_UInt32_0;

			// Token: 0x0400110F RID: 4367
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A4 RID: 420
		public class FloatField : DebugUI.Field<float>
		{
			// Token: 0x06001784 RID: 6020 RVA: 0x00064A08 File Offset: 0x00062C08
			// Note: this type is marked as 'beforefieldinit'.
			static FloatField()
			{
				Il2CppClassPointerStore<DebugUI.FloatField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "FloatField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.FloatField>.NativeClassPtr);
				DebugUI.FloatField.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.FloatField>.NativeClassPtr, "min");
				DebugUI.FloatField.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.FloatField>.NativeClassPtr, "max");
				DebugUI.FloatField.NativeFieldInfoPtr_incStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.FloatField>.NativeClassPtr, "incStep");
				DebugUI.FloatField.NativeFieldInfoPtr_incStepMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.FloatField>.NativeClassPtr, "incStepMult");
				DebugUI.FloatField.NativeFieldInfoPtr_decimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.FloatField>.NativeClassPtr, "decimals");
				DebugUI.FloatField.NativeMethodInfoPtr_ValidateValue_Public_Virtual_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.FloatField>.NativeClassPtr, 100664406);
				DebugUI.FloatField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.FloatField>.NativeClassPtr, 100664407);
			}

			// Token: 0x06001785 RID: 6021 RVA: 0x00064AC0 File Offset: 0x00062CC0
			[CallerCount(0)]
			public unsafe override float ValidateValue(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.FloatField.NativeMethodInfoPtr_ValidateValue_Public_Virtual_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001786 RID: 6022 RVA: 0x00064B14 File Offset: 0x00062D14
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 964113, RefRangeEnd = 964134, XrefRangeStart = 964110, XrefRangeEnd = 964113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.FloatField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.FloatField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001787 RID: 6023 RVA: 0x0000BB9F File Offset: 0x00009D9F
			public FloatField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x06001788 RID: 6024 RVA: 0x00064B50 File Offset: 0x00062D50
			// (set) Token: 0x06001789 RID: 6025 RVA: 0x0000BBA8 File Offset: 0x00009DA8
			public unsafe Func<float> min
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.FloatField.NativeFieldInfoPtr_min);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.FloatField.NativeFieldInfoPtr_min), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x0600178A RID: 6026 RVA: 0x00064B80 File Offset: 0x00062D80
			// (set) Token: 0x0600178B RID: 6027 RVA: 0x0000BBC7 File Offset: 0x00009DC7
			public unsafe Func<float> max
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.FloatField.NativeFieldInfoPtr_max);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.FloatField.NativeFieldInfoPtr_max), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x0600178C RID: 6028 RVA: 0x00064BB0 File Offset: 0x00062DB0
			// (set) Token: 0x0600178D RID: 6029 RVA: 0x0000BBE6 File Offset: 0x00009DE6
			public unsafe float incStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.FloatField.NativeFieldInfoPtr_incStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.FloatField.NativeFieldInfoPtr_incStep)) = value;
				}
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x0600178E RID: 6030 RVA: 0x00064BD8 File Offset: 0x00062DD8
			// (set) Token: 0x0600178F RID: 6031 RVA: 0x0000BC01 File Offset: 0x00009E01
			public unsafe float incStepMult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.FloatField.NativeFieldInfoPtr_incStepMult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.FloatField.NativeFieldInfoPtr_incStepMult)) = value;
				}
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x06001790 RID: 6032 RVA: 0x00064C00 File Offset: 0x00062E00
			// (set) Token: 0x06001791 RID: 6033 RVA: 0x0000BC1C File Offset: 0x00009E1C
			public unsafe int decimals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.FloatField.NativeFieldInfoPtr_decimals);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.FloatField.NativeFieldInfoPtr_decimals)) = value;
				}
			}

			// Token: 0x04001110 RID: 4368
			private static readonly IntPtr NativeFieldInfoPtr_min;

			// Token: 0x04001111 RID: 4369
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x04001112 RID: 4370
			private static readonly IntPtr NativeFieldInfoPtr_incStep;

			// Token: 0x04001113 RID: 4371
			private static readonly IntPtr NativeFieldInfoPtr_incStepMult;

			// Token: 0x04001114 RID: 4372
			private static readonly IntPtr NativeFieldInfoPtr_decimals;

			// Token: 0x04001115 RID: 4373
			private static readonly IntPtr NativeMethodInfoPtr_ValidateValue_Public_Virtual_Single_Single_0;

			// Token: 0x04001116 RID: 4374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A5 RID: 421
		public class EnumField<T> : DebugUI.Field<T>
		{
			// Token: 0x06001792 RID: 6034 RVA: 0x00064C28 File Offset: 0x00062E28
			// Note: this type is marked as 'beforefieldinit'.
			static EnumField()
			{
				Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "EnumField`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr);
				DebugUI.EnumField<T>.NativeFieldInfoPtr_enumNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr, "enumNames");
				DebugUI.EnumField<T>.NativeFieldInfoPtr_m_EnumValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr, "m_EnumValues");
				DebugUI.EnumField<T>.NativeFieldInfoPtr_s_NicifyRegEx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr, "s_NicifyRegEx");
				DebugUI.EnumField<T>.NativeMethodInfoPtr_get_enumValues_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr, 100664408);
				DebugUI.EnumField<T>.NativeMethodInfoPtr_set_enumValues_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr, 100664409);
				DebugUI.EnumField<T>.NativeMethodInfoPtr_AutoFillFromType_Protected_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr, 100664410);
				DebugUI.EnumField<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr, 100664411);
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06001793 RID: 6035 RVA: 0x00064D1C File Offset: 0x00062F1C
			// (set) Token: 0x06001794 RID: 6036 RVA: 0x00064D5C File Offset: 0x00062F5C
			public unsafe Il2CppStructArray<int> enumValues
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField<T>.NativeMethodInfoPtr_get_enumValues_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 964192, RefRangeEnd = 964196, XrefRangeStart = 964142, XrefRangeEnd = 964192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField<T>.NativeMethodInfoPtr_set_enumValues_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001795 RID: 6037 RVA: 0x00064DA0 File Offset: 0x00062FA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 964314, RefRangeEnd = 964315, XrefRangeStart = 964196, XrefRangeEnd = 964314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AutoFillFromType(Type enumType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField<T>.NativeMethodInfoPtr_AutoFillFromType_Protected_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001796 RID: 6038 RVA: 0x00064DE4 File Offset: 0x00062FE4
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 964341, RefRangeEnd = 964346, XrefRangeStart = 964315, XrefRangeEnd = 964341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnumField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001797 RID: 6039 RVA: 0x0000BC37 File Offset: 0x00009E37
			public EnumField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x06001798 RID: 6040 RVA: 0x00064E20 File Offset: 0x00063020
			// (set) Token: 0x06001799 RID: 6041 RVA: 0x0000BC40 File Offset: 0x00009E40
			public unsafe Il2CppReferenceArray<GUIContent> enumNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField<T>.NativeFieldInfoPtr_enumNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIContent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField<T>.NativeFieldInfoPtr_enumNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x0600179A RID: 6042 RVA: 0x00064E50 File Offset: 0x00063050
			// (set) Token: 0x0600179B RID: 6043 RVA: 0x0000BC5F File Offset: 0x00009E5F
			public unsafe Il2CppStructArray<int> m_EnumValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField<T>.NativeFieldInfoPtr_m_EnumValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField<T>.NativeFieldInfoPtr_m_EnumValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x0600179C RID: 6044 RVA: 0x00064E80 File Offset: 0x00063080
			// (set) Token: 0x0600179D RID: 6045 RVA: 0x0000BC7E File Offset: 0x00009E7E
			public unsafe static Regex s_NicifyRegEx
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugUI.EnumField<T>.NativeFieldInfoPtr_s_NicifyRegEx, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugUI.EnumField<T>.NativeFieldInfoPtr_s_NicifyRegEx, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001117 RID: 4375
			private static readonly IntPtr NativeFieldInfoPtr_enumNames;

			// Token: 0x04001118 RID: 4376
			private static readonly IntPtr NativeFieldInfoPtr_m_EnumValues;

			// Token: 0x04001119 RID: 4377
			private static readonly IntPtr NativeFieldInfoPtr_s_NicifyRegEx;

			// Token: 0x0400111A RID: 4378
			private static readonly IntPtr NativeMethodInfoPtr_get_enumValues_Public_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x0400111B RID: 4379
			private static readonly IntPtr NativeMethodInfoPtr_set_enumValues_Public_set_Void_Il2CppStructArray_1_Int32_0;

			// Token: 0x0400111C RID: 4380
			private static readonly IntPtr NativeMethodInfoPtr_AutoFillFromType_Protected_Void_Type_0;

			// Token: 0x0400111D RID: 4381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

			// Token: 0x02000232 RID: 562
			[ObfuscatedName("UnityEngine.Rendering.DebugUI+EnumField`1+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06001BE4 RID: 7140 RVA: 0x00071000 File Offset: 0x0006F200
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DebugUI.EnumField<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI.EnumField<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.EnumField<T>.__c>.NativeClassPtr);
					DebugUI.EnumField<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField<T>.__c>.NativeClassPtr, "<>9");
					DebugUI.EnumField<T>.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField<T>.__c>.NativeClassPtr, "<>9__6_0");
					DebugUI.EnumField<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField<T>.__c>.NativeClassPtr, 100664414);
					DebugUI.EnumField<T>.__c.NativeMethodInfoPtr__AutoFillFromType_b__6_0_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField<T>.__c>.NativeClassPtr, 100664415);
				}

				// Token: 0x06001BE5 RID: 7141 RVA: 0x000710B8 File Offset: 0x0006F2B8
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.EnumField<T>.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001BE6 RID: 7142 RVA: 0x000710F4 File Offset: 0x0006F2F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964134, XrefRangeEnd = 964142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _AutoFillFromType_b__6_0(FieldInfo fieldInfo)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldInfo);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField<T>.__c.NativeMethodInfoPtr__AutoFillFromType_b__6_0_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001BE7 RID: 7143 RVA: 0x0000DFED File Offset: 0x0000C1ED
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007D6 RID: 2006
				// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x00071144 File Offset: 0x0006F344
				// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0000DFF6 File Offset: 0x0000C1F6
				public unsafe static DebugUI.EnumField<T>.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugUI.EnumField<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.EnumField<T>.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugUI.EnumField<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170007D7 RID: 2007
				// (get) Token: 0x06001BEA RID: 7146 RVA: 0x0007116C File Offset: 0x0006F36C
				// (set) Token: 0x06001BEB RID: 7147 RVA: 0x0000E008 File Offset: 0x0000C208
				public unsafe static Func<FieldInfo, bool> __9__6_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugUI.EnumField<T>.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugUI.EnumField<T>.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001429 RID: 5161
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400142A RID: 5162
				private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

				// Token: 0x0400142B RID: 5163
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400142C RID: 5164
				private static readonly IntPtr NativeMethodInfoPtr__AutoFillFromType_b__6_0_Internal_Boolean_FieldInfo_0;
			}
		}

		// Token: 0x020001A6 RID: 422
		public class EnumField : DebugUI.EnumField<int>
		{
			// Token: 0x0600179E RID: 6046 RVA: 0x00064EA8 File Offset: 0x000630A8
			// Note: this type is marked as 'beforefieldinit'.
			static EnumField()
			{
				Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "EnumField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr);
				DebugUI.EnumField.NativeFieldInfoPtr_quickSeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, "quickSeparators");
				DebugUI.EnumField.NativeFieldInfoPtr_m_Indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, "m_Indexes");
				DebugUI.EnumField.NativeFieldInfoPtr__getIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, "<getIndex>k__BackingField");
				DebugUI.EnumField.NativeFieldInfoPtr__setIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, "<setIndex>k__BackingField");
				DebugUI.EnumField.NativeMethodInfoPtr_get_indexes_Internal_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664416);
				DebugUI.EnumField.NativeMethodInfoPtr_get_getIndex_Public_get_Func_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664417);
				DebugUI.EnumField.NativeMethodInfoPtr_set_getIndex_Public_set_Void_Func_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664418);
				DebugUI.EnumField.NativeMethodInfoPtr_get_setIndex_Public_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664419);
				DebugUI.EnumField.NativeMethodInfoPtr_set_setIndex_Public_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664420);
				DebugUI.EnumField.NativeMethodInfoPtr_get_currentIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664421);
				DebugUI.EnumField.NativeMethodInfoPtr_set_currentIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664422);
				DebugUI.EnumField.NativeMethodInfoPtr_set_autoEnum_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664423);
				DebugUI.EnumField.NativeMethodInfoPtr_InitQuickSeparators_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664424);
				DebugUI.EnumField.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664425);
				DebugUI.EnumField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, 100664426);
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x0600179F RID: 6047 RVA: 0x00065000 File Offset: 0x00063200
			public unsafe Il2CppStructArray<int> indexes
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964349, XrefRangeEnd = 964355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.NativeMethodInfoPtr_get_indexes_Internal_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00065040 File Offset: 0x00063240
			// (set) Token: 0x060017A1 RID: 6049 RVA: 0x00065080 File Offset: 0x00063280
			public unsafe Func<int> getIndex
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.NativeMethodInfoPtr_get_getIndex_Public_get_Func_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.NativeMethodInfoPtr_set_getIndex_Public_set_Void_Func_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x060017A2 RID: 6050 RVA: 0x000650C4 File Offset: 0x000632C4
			// (set) Token: 0x060017A3 RID: 6051 RVA: 0x00065104 File Offset: 0x00063304
			public unsafe Action<int> setIndex
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.NativeMethodInfoPtr_get_setIndex_Public_get_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.NativeMethodInfoPtr_set_setIndex_Public_set_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00065148 File Offset: 0x00063348
			// (set) Token: 0x060017A5 RID: 6053 RVA: 0x00065184 File Offset: 0x00063384
			public unsafe int currentIndex
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 964356, RefRangeEnd = 964360, XrefRangeStart = 964355, XrefRangeEnd = 964356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.NativeMethodInfoPtr_get_currentIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 964361, RefRangeEnd = 964363, XrefRangeStart = 964360, XrefRangeEnd = 964361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.NativeMethodInfoPtr_set_currentIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006A2 RID: 1698
			// (set) Token: 0x060017A6 RID: 6054 RVA: 0x000651C4 File Offset: 0x000633C4
			public unsafe Type autoEnum
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 964367, RefRangeEnd = 964381, XrefRangeStart = 964363, XrefRangeEnd = 964367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.NativeMethodInfoPtr_set_autoEnum_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060017A7 RID: 6055 RVA: 0x00065208 File Offset: 0x00063408
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 964417, RefRangeEnd = 964421, XrefRangeStart = 964381, XrefRangeEnd = 964417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InitQuickSeparators()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.NativeMethodInfoPtr_InitQuickSeparators_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017A8 RID: 6056 RVA: 0x0006523C File Offset: 0x0006343C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964421, XrefRangeEnd = 964428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void SetValue(int value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.EnumField.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017A9 RID: 6057 RVA: 0x00065288 File Offset: 0x00063488
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 964434, RefRangeEnd = 964449, XrefRangeStart = 964428, XrefRangeEnd = 964434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnumField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017AA RID: 6058 RVA: 0x0000BC90 File Offset: 0x00009E90
			public EnumField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x060017AB RID: 6059 RVA: 0x000652C4 File Offset: 0x000634C4
			// (set) Token: 0x060017AC RID: 6060 RVA: 0x0000BC99 File Offset: 0x00009E99
			public unsafe Il2CppStructArray<int> quickSeparators
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField.NativeFieldInfoPtr_quickSeparators);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField.NativeFieldInfoPtr_quickSeparators), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x060017AD RID: 6061 RVA: 0x000652F4 File Offset: 0x000634F4
			// (set) Token: 0x060017AE RID: 6062 RVA: 0x0000BCB8 File Offset: 0x00009EB8
			public unsafe Il2CppStructArray<int> m_Indexes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField.NativeFieldInfoPtr_m_Indexes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField.NativeFieldInfoPtr_m_Indexes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x060017AF RID: 6063 RVA: 0x00065324 File Offset: 0x00063524
			// (set) Token: 0x060017B0 RID: 6064 RVA: 0x0000BCD7 File Offset: 0x00009ED7
			public unsafe Func<int> _getIndex_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField.NativeFieldInfoPtr__getIndex_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField.NativeFieldInfoPtr__getIndex_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x060017B1 RID: 6065 RVA: 0x00065354 File Offset: 0x00063554
			// (set) Token: 0x060017B2 RID: 6066 RVA: 0x0000BCF6 File Offset: 0x00009EF6
			public unsafe Action<int> _setIndex_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField.NativeFieldInfoPtr__setIndex_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.EnumField.NativeFieldInfoPtr__setIndex_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400111E RID: 4382
			private static readonly IntPtr NativeFieldInfoPtr_quickSeparators;

			// Token: 0x0400111F RID: 4383
			private static readonly IntPtr NativeFieldInfoPtr_m_Indexes;

			// Token: 0x04001120 RID: 4384
			private static readonly IntPtr NativeFieldInfoPtr__getIndex_k__BackingField;

			// Token: 0x04001121 RID: 4385
			private static readonly IntPtr NativeFieldInfoPtr__setIndex_k__BackingField;

			// Token: 0x04001122 RID: 4386
			private static readonly IntPtr NativeMethodInfoPtr_get_indexes_Internal_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x04001123 RID: 4387
			private static readonly IntPtr NativeMethodInfoPtr_get_getIndex_Public_get_Func_1_Int32_0;

			// Token: 0x04001124 RID: 4388
			private static readonly IntPtr NativeMethodInfoPtr_set_getIndex_Public_set_Void_Func_1_Int32_0;

			// Token: 0x04001125 RID: 4389
			private static readonly IntPtr NativeMethodInfoPtr_get_setIndex_Public_get_Action_1_Int32_0;

			// Token: 0x04001126 RID: 4390
			private static readonly IntPtr NativeMethodInfoPtr_set_setIndex_Public_set_Void_Action_1_Int32_0;

			// Token: 0x04001127 RID: 4391
			private static readonly IntPtr NativeMethodInfoPtr_get_currentIndex_Public_get_Int32_0;

			// Token: 0x04001128 RID: 4392
			private static readonly IntPtr NativeMethodInfoPtr_set_currentIndex_Public_set_Void_Int32_0;

			// Token: 0x04001129 RID: 4393
			private static readonly IntPtr NativeMethodInfoPtr_set_autoEnum_Public_set_Void_Type_0;

			// Token: 0x0400112A RID: 4394
			private static readonly IntPtr NativeMethodInfoPtr_InitQuickSeparators_Internal_Void_0;

			// Token: 0x0400112B RID: 4395
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Int32_0;

			// Token: 0x0400112C RID: 4396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000233 RID: 563
			[ObfuscatedName("UnityEngine.Rendering.DebugUI+EnumField+<>c")]
			[Serializable]
			public new sealed class __c : Object
			{
				// Token: 0x06001BEC RID: 7148 RVA: 0x00071194 File Offset: 0x0006F394
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DebugUI.EnumField.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI.EnumField>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.EnumField.__c>.NativeClassPtr);
					DebugUI.EnumField.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField.__c>.NativeClassPtr, "<>9");
					DebugUI.EnumField.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.EnumField.__c>.NativeClassPtr, "<>9__17_0");
					DebugUI.EnumField.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField.__c>.NativeClassPtr, 100664428);
					DebugUI.EnumField.__c.NativeMethodInfoPtr__InitQuickSeparators_b__17_0_Internal_String_GUIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.EnumField.__c>.NativeClassPtr, 100664429);
				}

				// Token: 0x06001BED RID: 7149 RVA: 0x00071210 File Offset: 0x0006F410
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.EnumField.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001BEE RID: 7150 RVA: 0x0007124C File Offset: 0x0006F44C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964346, XrefRangeEnd = 964349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _InitQuickSeparators_b__17_0(GUIContent x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.EnumField.__c.NativeMethodInfoPtr__InitQuickSeparators_b__17_0_Internal_String_GUIContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x06001BEF RID: 7151 RVA: 0x0000E01A File Offset: 0x0000C21A
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007D8 RID: 2008
				// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x00071294 File Offset: 0x0006F494
				// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x0000E023 File Offset: 0x0000C223
				public unsafe static DebugUI.EnumField.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugUI.EnumField.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.EnumField.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugUI.EnumField.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170007D9 RID: 2009
				// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x000712BC File Offset: 0x0006F4BC
				// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x0000E035 File Offset: 0x0000C235
				public unsafe static Func<GUIContent, string> __9__17_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugUI.EnumField.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GUIContent, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugUI.EnumField.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400142D RID: 5165
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400142E RID: 5166
				private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

				// Token: 0x0400142F RID: 5167
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001430 RID: 5168
				private static readonly IntPtr NativeMethodInfoPtr__InitQuickSeparators_b__17_0_Internal_String_GUIContent_0;
			}
		}

		// Token: 0x020001A7 RID: 423
		public class ObjectPopupField : DebugUI.Field<Object>
		{
			// Token: 0x060017B3 RID: 6067 RVA: 0x00065384 File Offset: 0x00063584
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectPopupField()
			{
				Il2CppClassPointerStore<DebugUI.ObjectPopupField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "ObjectPopupField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.ObjectPopupField>.NativeClassPtr);
				DebugUI.ObjectPopupField.NativeFieldInfoPtr__getObjects_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ObjectPopupField>.NativeClassPtr, "<getObjects>k__BackingField");
				DebugUI.ObjectPopupField.NativeMethodInfoPtr_get_getObjects_Public_get_Func_1_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ObjectPopupField>.NativeClassPtr, 100664430);
				DebugUI.ObjectPopupField.NativeMethodInfoPtr_set_getObjects_Public_set_Void_Func_1_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ObjectPopupField>.NativeClassPtr, 100664431);
				DebugUI.ObjectPopupField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ObjectPopupField>.NativeClassPtr, 100664432);
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00065400 File Offset: 0x00063600
			// (set) Token: 0x060017B5 RID: 6069 RVA: 0x00065440 File Offset: 0x00063640
			public unsafe Func<IEnumerable<Object>> getObjects
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ObjectPopupField.NativeMethodInfoPtr_get_getObjects_Public_get_Func_1_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<Object>>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ObjectPopupField.NativeMethodInfoPtr_set_getObjects_Public_set_Void_Func_1_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060017B6 RID: 6070 RVA: 0x00065484 File Offset: 0x00063684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964449, XrefRangeEnd = 964452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectPopupField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.ObjectPopupField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ObjectPopupField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017B7 RID: 6071 RVA: 0x0000BD15 File Offset: 0x00009F15
			public ObjectPopupField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x060017B8 RID: 6072 RVA: 0x000654C0 File Offset: 0x000636C0
			// (set) Token: 0x060017B9 RID: 6073 RVA: 0x0000BD1E File Offset: 0x00009F1E
			public unsafe Func<IEnumerable<Object>> _getObjects_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ObjectPopupField.NativeFieldInfoPtr__getObjects_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<Object>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ObjectPopupField.NativeFieldInfoPtr__getObjects_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400112D RID: 4397
			private static readonly IntPtr NativeFieldInfoPtr__getObjects_k__BackingField;

			// Token: 0x0400112E RID: 4398
			private static readonly IntPtr NativeMethodInfoPtr_get_getObjects_Public_get_Func_1_IEnumerable_1_Object_0;

			// Token: 0x0400112F RID: 4399
			private static readonly IntPtr NativeMethodInfoPtr_set_getObjects_Public_set_Void_Func_1_IEnumerable_1_Object_0;

			// Token: 0x04001130 RID: 4400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A8 RID: 424
		public class HistoryEnumField : DebugUI.EnumField
		{
			// Token: 0x060017BA RID: 6074 RVA: 0x000654F0 File Offset: 0x000636F0
			// Note: this type is marked as 'beforefieldinit'.
			static HistoryEnumField()
			{
				Il2CppClassPointerStore<DebugUI.HistoryEnumField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "HistoryEnumField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.HistoryEnumField>.NativeClassPtr);
				DebugUI.HistoryEnumField.NativeFieldInfoPtr__historyIndexGetter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.HistoryEnumField>.NativeClassPtr, "<historyIndexGetter>k__BackingField");
				DebugUI.HistoryEnumField.NativeMethodInfoPtr_get_historyIndexGetter_Public_get_Il2CppReferenceArray_1_Func_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HistoryEnumField>.NativeClassPtr, 100664433);
				DebugUI.HistoryEnumField.NativeMethodInfoPtr_set_historyIndexGetter_Public_set_Void_Il2CppReferenceArray_1_Func_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HistoryEnumField>.NativeClassPtr, 100664434);
				DebugUI.HistoryEnumField.NativeMethodInfoPtr_get_historyDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HistoryEnumField>.NativeClassPtr, 100664435);
				DebugUI.HistoryEnumField.NativeMethodInfoPtr_GetHistoryValue_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HistoryEnumField>.NativeClassPtr, 100664436);
				DebugUI.HistoryEnumField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.HistoryEnumField>.NativeClassPtr, 100664437);
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x060017BB RID: 6075 RVA: 0x00065594 File Offset: 0x00063794
			// (set) Token: 0x060017BC RID: 6076 RVA: 0x000655D4 File Offset: 0x000637D4
			public unsafe Il2CppReferenceArray<Func<int>> historyIndexGetter
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HistoryEnumField.NativeMethodInfoPtr_get_historyIndexGetter_Public_get_Il2CppReferenceArray_1_Func_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Func<int>>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HistoryEnumField.NativeMethodInfoPtr_set_historyIndexGetter_Public_set_Void_Il2CppReferenceArray_1_Func_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x060017BD RID: 6077 RVA: 0x00065618 File Offset: 0x00063818
			public unsafe int historyDepth
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 964452, RefRangeEnd = 964454, XrefRangeStart = 964452, XrefRangeEnd = 964452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HistoryEnumField.NativeMethodInfoPtr_get_historyDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017BE RID: 6078 RVA: 0x00065654 File Offset: 0x00063854
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 964456, RefRangeEnd = 964457, XrefRangeStart = 964454, XrefRangeEnd = 964456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetHistoryValue(int historyIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref historyIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HistoryEnumField.NativeMethodInfoPtr_GetHistoryValue_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017BF RID: 6079 RVA: 0x000656A0 File Offset: 0x000638A0
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 964434, RefRangeEnd = 964449, XrefRangeStart = 964434, XrefRangeEnd = 964449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HistoryEnumField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.HistoryEnumField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.HistoryEnumField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017C0 RID: 6080 RVA: 0x0000BD3D File Offset: 0x00009F3D
			public HistoryEnumField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x060017C1 RID: 6081 RVA: 0x000656DC File Offset: 0x000638DC
			// (set) Token: 0x060017C2 RID: 6082 RVA: 0x0000BD46 File Offset: 0x00009F46
			public unsafe Il2CppReferenceArray<Func<int>> _historyIndexGetter_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.HistoryEnumField.NativeFieldInfoPtr__historyIndexGetter_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Func<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.HistoryEnumField.NativeFieldInfoPtr__historyIndexGetter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001131 RID: 4401
			private static readonly IntPtr NativeFieldInfoPtr__historyIndexGetter_k__BackingField;

			// Token: 0x04001132 RID: 4402
			private static readonly IntPtr NativeMethodInfoPtr_get_historyIndexGetter_Public_get_Il2CppReferenceArray_1_Func_1_Int32_0;

			// Token: 0x04001133 RID: 4403
			private static readonly IntPtr NativeMethodInfoPtr_set_historyIndexGetter_Public_set_Void_Il2CppReferenceArray_1_Func_1_Int32_0;

			// Token: 0x04001134 RID: 4404
			private static readonly IntPtr NativeMethodInfoPtr_get_historyDepth_Public_get_Int32_0;

			// Token: 0x04001135 RID: 4405
			private static readonly IntPtr NativeMethodInfoPtr_GetHistoryValue_Public_Int32_Int32_0;

			// Token: 0x04001136 RID: 4406
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001A9 RID: 425
		public class BitField : DebugUI.EnumField<Enum>
		{
			// Token: 0x060017C3 RID: 6083 RVA: 0x0006570C File Offset: 0x0006390C
			// Note: this type is marked as 'beforefieldinit'.
			static BitField()
			{
				Il2CppClassPointerStore<DebugUI.BitField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "BitField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.BitField>.NativeClassPtr);
				DebugUI.BitField.NativeFieldInfoPtr_m_EnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.BitField>.NativeClassPtr, "m_EnumType");
				DebugUI.BitField.NativeMethodInfoPtr_get_enumType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.BitField>.NativeClassPtr, 100664438);
				DebugUI.BitField.NativeMethodInfoPtr_set_enumType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.BitField>.NativeClassPtr, 100664439);
				DebugUI.BitField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.BitField>.NativeClassPtr, 100664440);
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00065788 File Offset: 0x00063988
			// (set) Token: 0x060017C5 RID: 6085 RVA: 0x000657C8 File Offset: 0x000639C8
			public unsafe Type enumType
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.BitField.NativeMethodInfoPtr_get_enumType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 964461, RefRangeEnd = 964462, XrefRangeStart = 964457, XrefRangeEnd = 964461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.BitField.NativeMethodInfoPtr_set_enumType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060017C6 RID: 6086 RVA: 0x0006580C File Offset: 0x00063A0C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 964468, RefRangeEnd = 964469, XrefRangeStart = 964462, XrefRangeEnd = 964468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BitField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.BitField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.BitField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017C7 RID: 6087 RVA: 0x0000BD65 File Offset: 0x00009F65
			public BitField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00065848 File Offset: 0x00063A48
			// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0000BD6E File Offset: 0x00009F6E
			public unsafe Type m_EnumType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.BitField.NativeFieldInfoPtr_m_EnumType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.BitField.NativeFieldInfoPtr_m_EnumType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001137 RID: 4407
			private static readonly IntPtr NativeFieldInfoPtr_m_EnumType;

			// Token: 0x04001138 RID: 4408
			private static readonly IntPtr NativeMethodInfoPtr_get_enumType_Public_get_Type_0;

			// Token: 0x04001139 RID: 4409
			private static readonly IntPtr NativeMethodInfoPtr_set_enumType_Public_set_Void_Type_0;

			// Token: 0x0400113A RID: 4410
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001AA RID: 426
		public class ColorField : DebugUI.Field<Color>
		{
			// Token: 0x060017CA RID: 6090 RVA: 0x00065878 File Offset: 0x00063A78
			// Note: this type is marked as 'beforefieldinit'.
			static ColorField()
			{
				Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "ColorField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr);
				DebugUI.ColorField.NativeFieldInfoPtr_hdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr, "hdr");
				DebugUI.ColorField.NativeFieldInfoPtr_showAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr, "showAlpha");
				DebugUI.ColorField.NativeFieldInfoPtr_showPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr, "showPicker");
				DebugUI.ColorField.NativeFieldInfoPtr_incStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr, "incStep");
				DebugUI.ColorField.NativeFieldInfoPtr_incStepMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr, "incStepMult");
				DebugUI.ColorField.NativeFieldInfoPtr_decimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr, "decimals");
				DebugUI.ColorField.NativeMethodInfoPtr_ValidateValue_Public_Virtual_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr, 100664441);
				DebugUI.ColorField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr, 100664442);
			}

			// Token: 0x060017CB RID: 6091 RVA: 0x00065944 File Offset: 0x00063B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964469, XrefRangeEnd = 964472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Color ValidateValue(Color value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.ColorField.NativeMethodInfoPtr_ValidateValue_Public_Virtual_Color_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017CC RID: 6092 RVA: 0x00065998 File Offset: 0x00063B98
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 964475, RefRangeEnd = 964477, XrefRangeStart = 964472, XrefRangeEnd = 964475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.ColorField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ColorField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017CD RID: 6093 RVA: 0x0000BD8D File Offset: 0x00009F8D
			public ColorField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x060017CE RID: 6094 RVA: 0x000659D4 File Offset: 0x00063BD4
			// (set) Token: 0x060017CF RID: 6095 RVA: 0x0000BD96 File Offset: 0x00009F96
			public unsafe bool hdr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_hdr);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_hdr)) = value;
				}
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x060017D0 RID: 6096 RVA: 0x000659FC File Offset: 0x00063BFC
			// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0000BDB1 File Offset: 0x00009FB1
			public unsafe bool showAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_showAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_showAlpha)) = value;
				}
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00065A24 File Offset: 0x00063C24
			// (set) Token: 0x060017D3 RID: 6099 RVA: 0x0000BDCC File Offset: 0x00009FCC
			public unsafe bool showPicker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_showPicker);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_showPicker)) = value;
				}
			}

			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00065A4C File Offset: 0x00063C4C
			// (set) Token: 0x060017D5 RID: 6101 RVA: 0x0000BDE7 File Offset: 0x00009FE7
			public unsafe float incStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_incStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_incStep)) = value;
				}
			}

			// Token: 0x170006AE RID: 1710
			// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00065A74 File Offset: 0x00063C74
			// (set) Token: 0x060017D7 RID: 6103 RVA: 0x0000BE02 File Offset: 0x0000A002
			public unsafe float incStepMult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_incStepMult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_incStepMult)) = value;
				}
			}

			// Token: 0x170006AF RID: 1711
			// (get) Token: 0x060017D8 RID: 6104 RVA: 0x00065A9C File Offset: 0x00063C9C
			// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0000BE1D File Offset: 0x0000A01D
			public unsafe int decimals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_decimals);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ColorField.NativeFieldInfoPtr_decimals)) = value;
				}
			}

			// Token: 0x0400113B RID: 4411
			private static readonly IntPtr NativeFieldInfoPtr_hdr;

			// Token: 0x0400113C RID: 4412
			private static readonly IntPtr NativeFieldInfoPtr_showAlpha;

			// Token: 0x0400113D RID: 4413
			private static readonly IntPtr NativeFieldInfoPtr_showPicker;

			// Token: 0x0400113E RID: 4414
			private static readonly IntPtr NativeFieldInfoPtr_incStep;

			// Token: 0x0400113F RID: 4415
			private static readonly IntPtr NativeFieldInfoPtr_incStepMult;

			// Token: 0x04001140 RID: 4416
			private static readonly IntPtr NativeFieldInfoPtr_decimals;

			// Token: 0x04001141 RID: 4417
			private static readonly IntPtr NativeMethodInfoPtr_ValidateValue_Public_Virtual_Color_Color_0;

			// Token: 0x04001142 RID: 4418
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001AB RID: 427
		public class Vector2Field : DebugUI.Field<Vector2>
		{
			// Token: 0x060017DA RID: 6106 RVA: 0x00065AC4 File Offset: 0x00063CC4
			// Note: this type is marked as 'beforefieldinit'.
			static Vector2Field()
			{
				Il2CppClassPointerStore<DebugUI.Vector2Field>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Vector2Field");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Vector2Field>.NativeClassPtr);
				DebugUI.Vector2Field.NativeFieldInfoPtr_incStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Vector2Field>.NativeClassPtr, "incStep");
				DebugUI.Vector2Field.NativeFieldInfoPtr_incStepMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Vector2Field>.NativeClassPtr, "incStepMult");
				DebugUI.Vector2Field.NativeFieldInfoPtr_decimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Vector2Field>.NativeClassPtr, "decimals");
				DebugUI.Vector2Field.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Vector2Field>.NativeClassPtr, 100664443);
			}

			// Token: 0x060017DB RID: 6107 RVA: 0x00065B40 File Offset: 0x00063D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964477, XrefRangeEnd = 964480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2Field()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Vector2Field>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Vector2Field.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017DC RID: 6108 RVA: 0x0000BE38 File Offset: 0x0000A038
			public Vector2Field(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B0 RID: 1712
			// (get) Token: 0x060017DD RID: 6109 RVA: 0x00065B7C File Offset: 0x00063D7C
			// (set) Token: 0x060017DE RID: 6110 RVA: 0x0000BE41 File Offset: 0x0000A041
			public unsafe float incStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector2Field.NativeFieldInfoPtr_incStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector2Field.NativeFieldInfoPtr_incStep)) = value;
				}
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x060017DF RID: 6111 RVA: 0x00065BA4 File Offset: 0x00063DA4
			// (set) Token: 0x060017E0 RID: 6112 RVA: 0x0000BE5C File Offset: 0x0000A05C
			public unsafe float incStepMult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector2Field.NativeFieldInfoPtr_incStepMult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector2Field.NativeFieldInfoPtr_incStepMult)) = value;
				}
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00065BCC File Offset: 0x00063DCC
			// (set) Token: 0x060017E2 RID: 6114 RVA: 0x0000BE77 File Offset: 0x0000A077
			public unsafe int decimals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector2Field.NativeFieldInfoPtr_decimals);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector2Field.NativeFieldInfoPtr_decimals)) = value;
				}
			}

			// Token: 0x04001143 RID: 4419
			private static readonly IntPtr NativeFieldInfoPtr_incStep;

			// Token: 0x04001144 RID: 4420
			private static readonly IntPtr NativeFieldInfoPtr_incStepMult;

			// Token: 0x04001145 RID: 4421
			private static readonly IntPtr NativeFieldInfoPtr_decimals;

			// Token: 0x04001146 RID: 4422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001AC RID: 428
		public class Vector3Field : DebugUI.Field<Vector3>
		{
			// Token: 0x060017E3 RID: 6115 RVA: 0x00065BF4 File Offset: 0x00063DF4
			// Note: this type is marked as 'beforefieldinit'.
			static Vector3Field()
			{
				Il2CppClassPointerStore<DebugUI.Vector3Field>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Vector3Field");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Vector3Field>.NativeClassPtr);
				DebugUI.Vector3Field.NativeFieldInfoPtr_incStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Vector3Field>.NativeClassPtr, "incStep");
				DebugUI.Vector3Field.NativeFieldInfoPtr_incStepMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Vector3Field>.NativeClassPtr, "incStepMult");
				DebugUI.Vector3Field.NativeFieldInfoPtr_decimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Vector3Field>.NativeClassPtr, "decimals");
				DebugUI.Vector3Field.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Vector3Field>.NativeClassPtr, 100664444);
			}

			// Token: 0x060017E4 RID: 6116 RVA: 0x00065C70 File Offset: 0x00063E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964480, XrefRangeEnd = 964483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3Field()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Vector3Field>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Vector3Field.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017E5 RID: 6117 RVA: 0x0000BE92 File Offset: 0x0000A092
			public Vector3Field(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00065CAC File Offset: 0x00063EAC
			// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0000BE9B File Offset: 0x0000A09B
			public unsafe float incStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector3Field.NativeFieldInfoPtr_incStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector3Field.NativeFieldInfoPtr_incStep)) = value;
				}
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00065CD4 File Offset: 0x00063ED4
			// (set) Token: 0x060017E9 RID: 6121 RVA: 0x0000BEB6 File Offset: 0x0000A0B6
			public unsafe float incStepMult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector3Field.NativeFieldInfoPtr_incStepMult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector3Field.NativeFieldInfoPtr_incStepMult)) = value;
				}
			}

			// Token: 0x170006B5 RID: 1717
			// (get) Token: 0x060017EA RID: 6122 RVA: 0x00065CFC File Offset: 0x00063EFC
			// (set) Token: 0x060017EB RID: 6123 RVA: 0x0000BED1 File Offset: 0x0000A0D1
			public unsafe int decimals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector3Field.NativeFieldInfoPtr_decimals);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector3Field.NativeFieldInfoPtr_decimals)) = value;
				}
			}

			// Token: 0x04001147 RID: 4423
			private static readonly IntPtr NativeFieldInfoPtr_incStep;

			// Token: 0x04001148 RID: 4424
			private static readonly IntPtr NativeFieldInfoPtr_incStepMult;

			// Token: 0x04001149 RID: 4425
			private static readonly IntPtr NativeFieldInfoPtr_decimals;

			// Token: 0x0400114A RID: 4426
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001AD RID: 429
		public class Vector4Field : DebugUI.Field<Vector4>
		{
			// Token: 0x060017EC RID: 6124 RVA: 0x00065D24 File Offset: 0x00063F24
			// Note: this type is marked as 'beforefieldinit'.
			static Vector4Field()
			{
				Il2CppClassPointerStore<DebugUI.Vector4Field>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Vector4Field");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Vector4Field>.NativeClassPtr);
				DebugUI.Vector4Field.NativeFieldInfoPtr_incStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Vector4Field>.NativeClassPtr, "incStep");
				DebugUI.Vector4Field.NativeFieldInfoPtr_incStepMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Vector4Field>.NativeClassPtr, "incStepMult");
				DebugUI.Vector4Field.NativeFieldInfoPtr_decimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Vector4Field>.NativeClassPtr, "decimals");
				DebugUI.Vector4Field.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Vector4Field>.NativeClassPtr, 100664445);
			}

			// Token: 0x060017ED RID: 6125 RVA: 0x00065DA0 File Offset: 0x00063FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964483, XrefRangeEnd = 964486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector4Field()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Vector4Field>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Vector4Field.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017EE RID: 6126 RVA: 0x0000BEEC File Offset: 0x0000A0EC
			public Vector4Field(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B6 RID: 1718
			// (get) Token: 0x060017EF RID: 6127 RVA: 0x00065DDC File Offset: 0x00063FDC
			// (set) Token: 0x060017F0 RID: 6128 RVA: 0x0000BEF5 File Offset: 0x0000A0F5
			public unsafe float incStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector4Field.NativeFieldInfoPtr_incStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector4Field.NativeFieldInfoPtr_incStep)) = value;
				}
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x060017F1 RID: 6129 RVA: 0x00065E04 File Offset: 0x00064004
			// (set) Token: 0x060017F2 RID: 6130 RVA: 0x0000BF10 File Offset: 0x0000A110
			public unsafe float incStepMult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector4Field.NativeFieldInfoPtr_incStepMult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector4Field.NativeFieldInfoPtr_incStepMult)) = value;
				}
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x060017F3 RID: 6131 RVA: 0x00065E2C File Offset: 0x0006402C
			// (set) Token: 0x060017F4 RID: 6132 RVA: 0x0000BF2B File Offset: 0x0000A12B
			public unsafe int decimals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector4Field.NativeFieldInfoPtr_decimals);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Vector4Field.NativeFieldInfoPtr_decimals)) = value;
				}
			}

			// Token: 0x0400114B RID: 4427
			private static readonly IntPtr NativeFieldInfoPtr_incStep;

			// Token: 0x0400114C RID: 4428
			private static readonly IntPtr NativeFieldInfoPtr_incStepMult;

			// Token: 0x0400114D RID: 4429
			private static readonly IntPtr NativeFieldInfoPtr_decimals;

			// Token: 0x0400114E RID: 4430
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001AE RID: 430
		public class ObjectField : DebugUI.Field<Object>
		{
			// Token: 0x060017F5 RID: 6133 RVA: 0x00065E54 File Offset: 0x00064054
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectField()
			{
				Il2CppClassPointerStore<DebugUI.ObjectField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "ObjectField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.ObjectField>.NativeClassPtr);
				DebugUI.ObjectField.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ObjectField>.NativeClassPtr, "type");
				DebugUI.ObjectField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ObjectField>.NativeClassPtr, 100664446);
			}

			// Token: 0x060017F6 RID: 6134 RVA: 0x00065EA8 File Offset: 0x000640A8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 964496, RefRangeEnd = 964498, XrefRangeStart = 964486, XrefRangeEnd = 964496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.ObjectField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ObjectField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017F7 RID: 6135 RVA: 0x0000BF46 File Offset: 0x0000A146
			public ObjectField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x060017F8 RID: 6136 RVA: 0x00065EE4 File Offset: 0x000640E4
			// (set) Token: 0x060017F9 RID: 6137 RVA: 0x0000BF4F File Offset: 0x0000A14F
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ObjectField.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ObjectField.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400114F RID: 4431
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001150 RID: 4432
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001AF RID: 431
		public class ObjectListField : DebugUI.Field<Il2CppReferenceArray<Object>>
		{
			// Token: 0x060017FA RID: 6138 RVA: 0x00065F14 File Offset: 0x00064114
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectListField()
			{
				Il2CppClassPointerStore<DebugUI.ObjectListField>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "ObjectListField");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.ObjectListField>.NativeClassPtr);
				DebugUI.ObjectListField.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.ObjectListField>.NativeClassPtr, "type");
				DebugUI.ObjectListField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.ObjectListField>.NativeClassPtr, 100664447);
			}

			// Token: 0x060017FB RID: 6139 RVA: 0x00065F68 File Offset: 0x00064168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964498, XrefRangeEnd = 964508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectListField()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.ObjectListField>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.ObjectListField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017FC RID: 6140 RVA: 0x0000BF6E File Offset: 0x0000A16E
			public ObjectListField(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006BA RID: 1722
			// (get) Token: 0x060017FD RID: 6141 RVA: 0x00065FA4 File Offset: 0x000641A4
			// (set) Token: 0x060017FE RID: 6142 RVA: 0x0000BF77 File Offset: 0x0000A177
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ObjectListField.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.ObjectListField.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001151 RID: 4433
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001152 RID: 4434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001B0 RID: 432
		public class MessageBox : DebugUI.Widget
		{
			// Token: 0x060017FF RID: 6143 RVA: 0x00065FD4 File Offset: 0x000641D4
			// Note: this type is marked as 'beforefieldinit'.
			static MessageBox()
			{
				Il2CppClassPointerStore<DebugUI.MessageBox>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "MessageBox");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.MessageBox>.NativeClassPtr);
				DebugUI.MessageBox.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.MessageBox>.NativeClassPtr, "style");
				DebugUI.MessageBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.MessageBox>.NativeClassPtr, 100664448);
			}

			// Token: 0x06001800 RID: 6144 RVA: 0x00066028 File Offset: 0x00064228
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageBox()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.MessageBox>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.MessageBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001801 RID: 6145 RVA: 0x0000BF96 File Offset: 0x0000A196
			public MessageBox(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x06001802 RID: 6146 RVA: 0x00066064 File Offset: 0x00064264
			// (set) Token: 0x06001803 RID: 6147 RVA: 0x0000BF9F File Offset: 0x0000A19F
			public unsafe DebugUI.MessageBox.Style style
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.MessageBox.NativeFieldInfoPtr_style);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.MessageBox.NativeFieldInfoPtr_style)) = value;
				}
			}

			// Token: 0x04001153 RID: 4435
			private static readonly IntPtr NativeFieldInfoPtr_style;

			// Token: 0x04001154 RID: 4436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000234 RID: 564
			public enum Style
			{
				// Token: 0x04001432 RID: 5170
				Info,
				// Token: 0x04001433 RID: 5171
				Warning,
				// Token: 0x04001434 RID: 5172
				Error
			}
		}

		// Token: 0x020001B1 RID: 433
		public class Panel : Object
		{
			// Token: 0x06001804 RID: 6148 RVA: 0x0006608C File Offset: 0x0006428C
			// Note: this type is marked as 'beforefieldinit'.
			static Panel()
			{
				Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI>.NativeClassPtr, "Panel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr);
				DebugUI.Panel.NativeFieldInfoPtr__flags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, "<flags>k__BackingField");
				DebugUI.Panel.NativeFieldInfoPtr__displayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, "<displayName>k__BackingField");
				DebugUI.Panel.NativeFieldInfoPtr__groupIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, "<groupIndex>k__BackingField");
				DebugUI.Panel.NativeFieldInfoPtr__children_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, "<children>k__BackingField");
				DebugUI.Panel.NativeFieldInfoPtr_onSetDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, "onSetDirty");
				DebugUI.Panel.NativeMethodInfoPtr_get_flags_Public_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664449);
				DebugUI.Panel.NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664450);
				DebugUI.Panel.NativeMethodInfoPtr_get_displayName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664451);
				DebugUI.Panel.NativeMethodInfoPtr_set_displayName_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664452);
				DebugUI.Panel.NativeMethodInfoPtr_get_groupIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664453);
				DebugUI.Panel.NativeMethodInfoPtr_set_groupIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664454);
				DebugUI.Panel.NativeMethodInfoPtr_get_queryPath_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664455);
				DebugUI.Panel.NativeMethodInfoPtr_get_isEditorOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664456);
				DebugUI.Panel.NativeMethodInfoPtr_get_isRuntimeOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664457);
				DebugUI.Panel.NativeMethodInfoPtr_get_isInactiveInEditor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664458);
				DebugUI.Panel.NativeMethodInfoPtr_get_editorForceUpdate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664459);
				DebugUI.Panel.NativeMethodInfoPtr_get_children_Public_Virtual_Final_New_get_ObservableList_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664460);
				DebugUI.Panel.NativeMethodInfoPtr_set_children_Private_set_Void_ObservableList_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664461);
				DebugUI.Panel.NativeMethodInfoPtr_add_onSetDirty_Public_add_Void_Action_1_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664462);
				DebugUI.Panel.NativeMethodInfoPtr_remove_onSetDirty_Public_rem_Void_Action_1_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664463);
				DebugUI.Panel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664464);
				DebugUI.Panel.NativeMethodInfoPtr_OnItemAdded_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664465);
				DebugUI.Panel.NativeMethodInfoPtr_OnItemRemoved_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664466);
				DebugUI.Panel.NativeMethodInfoPtr_SetDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664467);
				DebugUI.Panel.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664468);
				DebugUI.Panel.NativeMethodInfoPtr_System_IComparable_UnityEngine_Rendering_DebugUI_Panel__CompareTo_Private_Virtual_Final_New_Int32_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, 100664469);
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x06001805 RID: 6149 RVA: 0x000662C0 File Offset: 0x000644C0
			// (set) Token: 0x06001806 RID: 6150 RVA: 0x000662FC File Offset: 0x000644FC
			public unsafe DebugUI.Flags flags
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_get_flags_Public_get_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006C2 RID: 1730
			// (get) Token: 0x06001807 RID: 6151 RVA: 0x0006633C File Offset: 0x0006453C
			// (set) Token: 0x06001808 RID: 6152 RVA: 0x00066374 File Offset: 0x00064574
			public unsafe virtual string displayName
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_get_displayName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_set_displayName_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006C3 RID: 1731
			// (get) Token: 0x06001809 RID: 6153 RVA: 0x000663B8 File Offset: 0x000645B8
			// (set) Token: 0x0600180A RID: 6154 RVA: 0x000663F4 File Offset: 0x000645F4
			public unsafe int groupIndex
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_get_groupIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_set_groupIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006C4 RID: 1732
			// (get) Token: 0x0600180B RID: 6155 RVA: 0x00066434 File Offset: 0x00064634
			public unsafe virtual string queryPath
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_get_queryPath_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x0600180C RID: 6156 RVA: 0x0006646C File Offset: 0x0006466C
			public unsafe bool isEditorOnly
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 964508, RefRangeEnd = 964509, XrefRangeStart = 964508, XrefRangeEnd = 964508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_get_isEditorOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170006C6 RID: 1734
			// (get) Token: 0x0600180D RID: 6157 RVA: 0x000664A8 File Offset: 0x000646A8
			public unsafe bool isRuntimeOnly
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_get_isRuntimeOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x0600180E RID: 6158 RVA: 0x000664E4 File Offset: 0x000646E4
			public unsafe bool isInactiveInEditor
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964509, XrefRangeEnd = 964510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_get_isInactiveInEditor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x0600180F RID: 6159 RVA: 0x00066520 File Offset: 0x00064720
			public unsafe bool editorForceUpdate
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_get_editorForceUpdate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x06001810 RID: 6160 RVA: 0x0006655C File Offset: 0x0006475C
			// (set) Token: 0x06001811 RID: 6161 RVA: 0x0006659C File Offset: 0x0006479C
			public unsafe virtual ObservableList<DebugUI.Widget> children
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_get_children_Public_Virtual_Final_New_get_ObservableList_1_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObservableList<DebugUI.Widget>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_set_children_Private_set_Void_ObservableList_1_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001812 RID: 6162 RVA: 0x000665E0 File Offset: 0x000647E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964510, XrefRangeEnd = 964515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void add_onSetDirty(Action<DebugUI.Panel> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_add_onSetDirty_Public_add_Void_Action_1_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001813 RID: 6163 RVA: 0x00066624 File Offset: 0x00064824
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 964520, RefRangeEnd = 964522, XrefRangeStart = 964515, XrefRangeEnd = 964520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void remove_onSetDirty(Action<DebugUI.Panel> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_remove_onSetDirty_Public_rem_Void_Action_1_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001814 RID: 6164 RVA: 0x00066668 File Offset: 0x00064868
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 964560, RefRangeEnd = 964561, XrefRangeStart = 964522, XrefRangeEnd = 964560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Panel()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001815 RID: 6165 RVA: 0x000666A4 File Offset: 0x000648A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964561, XrefRangeEnd = 964563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnItemAdded(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Panel.NativeMethodInfoPtr_OnItemAdded_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001816 RID: 6166 RVA: 0x00066704 File Offset: 0x00064904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964563, XrefRangeEnd = 964565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnItemRemoved(ObservableList<DebugUI.Widget> sender, ListChangedEventArgs<DebugUI.Widget> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Panel.NativeMethodInfoPtr_OnItemRemoved_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001817 RID: 6167 RVA: 0x00066764 File Offset: 0x00064964
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 964572, RefRangeEnd = 964578, XrefRangeStart = 964565, XrefRangeEnd = 964572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetDirty()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_SetDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001818 RID: 6168 RVA: 0x00066798 File Offset: 0x00064998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964578, XrefRangeEnd = 964584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUI.Panel.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001819 RID: 6169 RVA: 0x000667E0 File Offset: 0x000649E0
			[CallerCount(0)]
			public unsafe virtual int System_IComparable_UnityEngine_Rendering_DebugUI_Panel__CompareTo(DebugUI.Panel other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.NativeMethodInfoPtr_System_IComparable_UnityEngine_Rendering_DebugUI_Panel__CompareTo_Private_Virtual_Final_New_Int32_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600181A RID: 6170 RVA: 0x0000BFBA File Offset: 0x0000A1BA
			public Panel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006BC RID: 1724
			// (get) Token: 0x0600181B RID: 6171 RVA: 0x00066830 File Offset: 0x00064A30
			// (set) Token: 0x0600181C RID: 6172 RVA: 0x0000BFC3 File Offset: 0x0000A1C3
			public unsafe DebugUI.Flags _flags_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Panel.NativeFieldInfoPtr__flags_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Panel.NativeFieldInfoPtr__flags_k__BackingField)) = value;
				}
			}

			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x0600181D RID: 6173 RVA: 0x00066858 File Offset: 0x00064A58
			// (set) Token: 0x0600181E RID: 6174 RVA: 0x0000BFDE File Offset: 0x0000A1DE
			public unsafe string _displayName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Panel.NativeFieldInfoPtr__displayName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Panel.NativeFieldInfoPtr__displayName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x0600181F RID: 6175 RVA: 0x00066880 File Offset: 0x00064A80
			// (set) Token: 0x06001820 RID: 6176 RVA: 0x0000BFFD File Offset: 0x0000A1FD
			public unsafe int _groupIndex_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Panel.NativeFieldInfoPtr__groupIndex_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Panel.NativeFieldInfoPtr__groupIndex_k__BackingField)) = value;
				}
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x06001821 RID: 6177 RVA: 0x000668A8 File Offset: 0x00064AA8
			// (set) Token: 0x06001822 RID: 6178 RVA: 0x0000C018 File Offset: 0x0000A218
			public unsafe ObservableList<DebugUI.Widget> _children_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Panel.NativeFieldInfoPtr__children_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObservableList<DebugUI.Widget>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Panel.NativeFieldInfoPtr__children_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x06001823 RID: 6179 RVA: 0x000668D8 File Offset: 0x00064AD8
			// (set) Token: 0x06001824 RID: 6180 RVA: 0x0000C037 File Offset: 0x0000A237
			public unsafe Action<DebugUI.Panel> onSetDirty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Panel.NativeFieldInfoPtr_onSetDirty);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DebugUI.Panel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUI.Panel.NativeFieldInfoPtr_onSetDirty), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001155 RID: 4437
			private static readonly IntPtr NativeFieldInfoPtr__flags_k__BackingField;

			// Token: 0x04001156 RID: 4438
			private static readonly IntPtr NativeFieldInfoPtr__displayName_k__BackingField;

			// Token: 0x04001157 RID: 4439
			private static readonly IntPtr NativeFieldInfoPtr__groupIndex_k__BackingField;

			// Token: 0x04001158 RID: 4440
			private static readonly IntPtr NativeFieldInfoPtr__children_k__BackingField;

			// Token: 0x04001159 RID: 4441
			private static readonly IntPtr NativeFieldInfoPtr_onSetDirty;

			// Token: 0x0400115A RID: 4442
			private static readonly IntPtr NativeMethodInfoPtr_get_flags_Public_get_Flags_0;

			// Token: 0x0400115B RID: 4443
			private static readonly IntPtr NativeMethodInfoPtr_set_flags_Public_set_Void_Flags_0;

			// Token: 0x0400115C RID: 4444
			private static readonly IntPtr NativeMethodInfoPtr_get_displayName_Public_Virtual_Final_New_get_String_0;

			// Token: 0x0400115D RID: 4445
			private static readonly IntPtr NativeMethodInfoPtr_set_displayName_Public_Virtual_Final_New_set_Void_String_0;

			// Token: 0x0400115E RID: 4446
			private static readonly IntPtr NativeMethodInfoPtr_get_groupIndex_Public_get_Int32_0;

			// Token: 0x0400115F RID: 4447
			private static readonly IntPtr NativeMethodInfoPtr_set_groupIndex_Public_set_Void_Int32_0;

			// Token: 0x04001160 RID: 4448
			private static readonly IntPtr NativeMethodInfoPtr_get_queryPath_Public_Virtual_Final_New_get_String_0;

			// Token: 0x04001161 RID: 4449
			private static readonly IntPtr NativeMethodInfoPtr_get_isEditorOnly_Public_get_Boolean_0;

			// Token: 0x04001162 RID: 4450
			private static readonly IntPtr NativeMethodInfoPtr_get_isRuntimeOnly_Public_get_Boolean_0;

			// Token: 0x04001163 RID: 4451
			private static readonly IntPtr NativeMethodInfoPtr_get_isInactiveInEditor_Public_get_Boolean_0;

			// Token: 0x04001164 RID: 4452
			private static readonly IntPtr NativeMethodInfoPtr_get_editorForceUpdate_Public_get_Boolean_0;

			// Token: 0x04001165 RID: 4453
			private static readonly IntPtr NativeMethodInfoPtr_get_children_Public_Virtual_Final_New_get_ObservableList_1_Widget_0;

			// Token: 0x04001166 RID: 4454
			private static readonly IntPtr NativeMethodInfoPtr_set_children_Private_set_Void_ObservableList_1_Widget_0;

			// Token: 0x04001167 RID: 4455
			private static readonly IntPtr NativeMethodInfoPtr_add_onSetDirty_Public_add_Void_Action_1_Panel_0;

			// Token: 0x04001168 RID: 4456
			private static readonly IntPtr NativeMethodInfoPtr_remove_onSetDirty_Public_rem_Void_Action_1_Panel_0;

			// Token: 0x04001169 RID: 4457
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400116A RID: 4458
			private static readonly IntPtr NativeMethodInfoPtr_OnItemAdded_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0;

			// Token: 0x0400116B RID: 4459
			private static readonly IntPtr NativeMethodInfoPtr_OnItemRemoved_Protected_Virtual_New_Void_ObservableList_1_Widget_ListChangedEventArgs_1_Widget_0;

			// Token: 0x0400116C RID: 4460
			private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Public_Void_0;

			// Token: 0x0400116D RID: 4461
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x0400116E RID: 4462
			private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_UnityEngine_Rendering_DebugUI_Panel__CompareTo_Private_Virtual_Final_New_Int32_Panel_0;

			// Token: 0x02000235 RID: 565
			[ObfuscatedName("UnityEngine.Rendering.DebugUI+Panel+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06001BF4 RID: 7156 RVA: 0x000712E4 File Offset: 0x0006F4E4
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DebugUI.Panel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUI.Panel>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUI.Panel.__c>.NativeClassPtr);
					DebugUI.Panel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Panel.__c>.NativeClassPtr, "<>9");
					DebugUI.Panel.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUI.Panel.__c>.NativeClassPtr, "<>9__29_0");
					DebugUI.Panel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel.__c>.NativeClassPtr, 100664471);
					DebugUI.Panel.__c.NativeMethodInfoPtr___ctor_b__29_0_Internal_Void_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUI.Panel.__c>.NativeClassPtr, 100664472);
				}

				// Token: 0x06001BF5 RID: 7157 RVA: 0x00071360 File Offset: 0x0006F560
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUI.Panel.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001BF6 RID: 7158 RVA: 0x0007139C File Offset: 0x0006F59C
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __ctor_b__29_0(DebugUI.Panel <p0>)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUI.Panel.__c.NativeMethodInfoPtr___ctor_b__29_0_Internal_Void_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001BF7 RID: 7159 RVA: 0x0000E047 File Offset: 0x0000C247
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170007DA RID: 2010
				// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x000713E0 File Offset: 0x0006F5E0
				// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x0000E050 File Offset: 0x0000C250
				public unsafe static DebugUI.Panel.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugUI.Panel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Panel.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugUI.Panel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170007DB RID: 2011
				// (get) Token: 0x06001BFA RID: 7162 RVA: 0x00071408 File Offset: 0x0006F608
				// (set) Token: 0x06001BFB RID: 7163 RVA: 0x0000E062 File Offset: 0x0000C262
				public unsafe static Action<DebugUI.Panel> __9__29_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugUI.Panel.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DebugUI.Panel>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugUI.Panel.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001435 RID: 5173
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04001436 RID: 5174
				private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

				// Token: 0x04001437 RID: 5175
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001438 RID: 5176
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__29_0_Internal_Void_Panel_0;
			}
		}
	}
}
