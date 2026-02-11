using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BA RID: 186
	public class DropdownMenu : Object
	{
		// Token: 0x0600113E RID: 4414 RVA: 0x00059668 File Offset: 0x00057868
		// Note: this type is marked as 'beforefieldinit'.
		static DropdownMenu()
		{
			Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DropdownMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr);
			DropdownMenu.NativeFieldInfoPtr_m_MenuItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr, "m_MenuItems");
			DropdownMenu.NativeFieldInfoPtr_m_DropdownMenuEventInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr, "m_DropdownMenuEventInfo");
			DropdownMenu.NativeMethodInfoPtr_MenuItems_Public_List_1_DropdownMenuItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr, 100665737);
			DropdownMenu.NativeMethodInfoPtr_AppendAction_Public_Void_String_Action_1_DropdownMenuAction_Func_2_DropdownMenuAction_Status_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr, 100665738);
			DropdownMenu.NativeMethodInfoPtr_AppendAction_Public_Void_String_Action_1_DropdownMenuAction_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr, 100665739);
			DropdownMenu.NativeMethodInfoPtr_AppendSeparator_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr, 100665740);
			DropdownMenu.NativeMethodInfoPtr_InsertSeparator_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr, 100665741);
			DropdownMenu.NativeMethodInfoPtr_PrepareForDisplay_Public_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr, 100665742);
			DropdownMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr, 100665743);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0005974C File Offset: 0x0005794C
		[CallerCount(169)]
		[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DropdownMenuItem> MenuItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenu.NativeMethodInfoPtr_MenuItems_Public_List_1_DropdownMenuItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DropdownMenuItem>>(intPtr3) : null;
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0005978C File Offset: 0x0005798C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311442, RefRangeEnd = 311445, XrefRangeStart = 311431, XrefRangeEnd = 311442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, Object userData = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionStatusCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenu.NativeMethodInfoPtr_AppendAction_Public_Void_String_Action_1_DropdownMenuAction_Func_2_DropdownMenuAction_Status_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00059808 File Offset: 0x00057A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311458, RefRangeEnd = 311459, XrefRangeStart = 311445, XrefRangeEnd = 311458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendAction(string actionName, Action<DropdownMenuAction> action, DropdownMenuAction.Status status = DropdownMenuAction.Status.Normal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenu.NativeMethodInfoPtr_AppendAction_Public_Void_String_Action_1_DropdownMenuAction_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0005986C File Offset: 0x00057A6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311474, RefRangeEnd = 311475, XrefRangeStart = 311459, XrefRangeEnd = 311474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendSeparator(string subMenuPath = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subMenuPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenu.NativeMethodInfoPtr_AppendSeparator_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x000598B0 File Offset: 0x00057AB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311490, RefRangeEnd = 311491, XrefRangeStart = 311475, XrefRangeEnd = 311490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertSeparator(string subMenuPath, int atIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subMenuPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenu.NativeMethodInfoPtr_InsertSeparator_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00059900 File Offset: 0x00057B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311524, RefRangeEnd = 311525, XrefRangeStart = 311491, XrefRangeEnd = 311524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareForDisplay(EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenu.NativeMethodInfoPtr_PrepareForDisplay_Public_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00059944 File Offset: 0x00057B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311533, RefRangeEnd = 311534, XrefRangeStart = 311525, XrefRangeEnd = 311533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownMenu()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00008A9C File Offset: 0x00006C9C
		public DropdownMenu(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x00059980 File Offset: 0x00057B80
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x00008AA5 File Offset: 0x00006CA5
		public unsafe List<DropdownMenuItem> m_MenuItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenu.NativeFieldInfoPtr_m_MenuItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DropdownMenuItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenu.NativeFieldInfoPtr_m_MenuItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x000599B0 File Offset: 0x00057BB0
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x00008AC4 File Offset: 0x00006CC4
		public unsafe DropdownMenuEventInfo m_DropdownMenuEventInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenu.NativeFieldInfoPtr_m_DropdownMenuEventInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DropdownMenuEventInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenu.NativeFieldInfoPtr_m_DropdownMenuEventInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x000599E0 File Offset: 0x00057BE0
		public void InsertAction(int atIndex, string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, [Optional] Object userData)
		{
			DropdownMenuAction dropdownMenuAction = new DropdownMenuAction(actionName, action, actionStatusCallback, userData);
			this.m_MenuItems.Insert(atIndex, dropdownMenuAction);
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00008AE3 File Offset: 0x00006CE3
		public void InsertAction(int atIndex, string actionName, Action<DropdownMenuAction> action, [Optional] DropdownMenuAction.Status status)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00008AF0 File Offset: 0x00006CF0
		public void RemoveItemAt(int index)
		{
			this.m_MenuItems.RemoveAt(index);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00008B00 File Offset: 0x00006D00
		public void ClearItems()
		{
			this.m_MenuItems.Clear();
		}

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeFieldInfoPtr_m_MenuItems;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeFieldInfoPtr_m_DropdownMenuEventInfo;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_MenuItems_Public_List_1_DropdownMenuItem_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_AppendAction_Public_Void_String_Action_1_DropdownMenuAction_Func_2_DropdownMenuAction_Status_Object_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_AppendAction_Public_Void_String_Action_1_DropdownMenuAction_Status_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_AppendSeparator_Public_Void_String_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_InsertSeparator_Public_Void_String_Int32_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForDisplay_Public_Void_EventBase_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003E4 RID: 996
		[ObfuscatedName("UnityEngine.UIElements.DropdownMenu+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06003A73 RID: 14963 RVA: 0x000ECB84 File Offset: 0x000EAD84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DropdownMenu.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropdownMenu>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownMenu.__c__DisplayClass4_0>.NativeClassPtr);
				DropdownMenu.__c__DisplayClass4_0.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownMenu.__c__DisplayClass4_0>.NativeClassPtr, "status");
				DropdownMenu.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenu.__c__DisplayClass4_0>.NativeClassPtr, 100665744);
				DropdownMenu.__c__DisplayClass4_0.NativeMethodInfoPtr__AppendAction_b__0_Internal_Status_DropdownMenuAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownMenu.__c__DisplayClass4_0>.NativeClassPtr, 100665745);
			}

			// Token: 0x06003A74 RID: 14964 RVA: 0x000ECBEC File Offset: 0x000EADEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownMenu.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenu.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A75 RID: 14965 RVA: 0x000ECC28 File Offset: 0x000EAE28
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DropdownMenuAction.Status _AppendAction_b__0(DropdownMenuAction e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownMenu.__c__DisplayClass4_0.NativeMethodInfoPtr__AppendAction_b__0_Internal_Status_DropdownMenuAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003A76 RID: 14966 RVA: 0x00018AEA File Offset: 0x00016CEA
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011EE RID: 4590
			// (get) Token: 0x06003A77 RID: 14967 RVA: 0x000ECC78 File Offset: 0x000EAE78
			// (set) Token: 0x06003A78 RID: 14968 RVA: 0x00018AF3 File Offset: 0x00016CF3
			public unsafe DropdownMenuAction.Status status
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenu.__c__DisplayClass4_0.NativeFieldInfoPtr_status);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownMenu.__c__DisplayClass4_0.NativeFieldInfoPtr_status)) = value;
				}
			}

			// Token: 0x04002956 RID: 10582
			private static readonly IntPtr NativeFieldInfoPtr_status;

			// Token: 0x04002957 RID: 10583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002958 RID: 10584
			private static readonly IntPtr NativeMethodInfoPtr__AppendAction_b__0_Internal_Status_DropdownMenuAction_0;
		}

		// Token: 0x020003E5 RID: 997
		public sealed class <>c__DisplayClass4_0
		{
		}

		// Token: 0x020003E6 RID: 998
		public sealed class <>c__DisplayClass6_0
		{
		}
	}
}
