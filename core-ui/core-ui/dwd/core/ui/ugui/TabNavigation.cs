using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace dwd.core.ui.ugui
{
	// Token: 0x02000018 RID: 24
	public class TabNavigation : MonoBehaviour
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00005C04 File Offset: 0x00003E04
		// Note: this type is marked as 'beforefieldinit'.
		static TabNavigation()
		{
			Il2CppClassPointerStore<TabNavigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-ui.dll", "dwd.core.ui.ugui", "TabNavigation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr);
			TabNavigation.NativeFieldInfoPtr_desiredDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, "desiredDirection");
			TabNavigation.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, "selectable");
			TabNavigation.NativeFieldInfoPtr_system = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, "system");
			TabNavigation.NativeFieldInfoPtr_wasSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, "wasSelected");
			TabNavigation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663419);
			TabNavigation.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663420);
			TabNavigation.NativeMethodInfoPtr_getNext_Private_Selectable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663421);
			TabNavigation.NativeMethodInfoPtr_getNext_Private_Selectable_Selectable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663422);
			TabNavigation.NativeMethodInfoPtr_GetNext_Public_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663423);
			TabNavigation.NativeMethodInfoPtr_GetNext_Public_Selectable_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663424);
			TabNavigation.NativeMethodInfoPtr_GetPrevious_Public_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663425);
			TabNavigation.NativeMethodInfoPtr_GetPrevious_Public_Selectable_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663426);
			TabNavigation.NativeMethodInfoPtr_select_Private_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663427);
			TabNavigation.NativeMethodInfoPtr_shouldCheckAutomatic_Private_Boolean_Selectable_MoveDirection_byref_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663428);
			TabNavigation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr, 100663429);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005D60 File Offset: 0x00003F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254402, XrefRangeEnd = 1254415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005D94 File Offset: 0x00003F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254415, XrefRangeEnd = 1254433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005DC8 File Offset: 0x00003FC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1254441, RefRangeEnd = 1254445, XrefRangeStart = 1254433, XrefRangeEnd = 1254441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable getNext(bool forward)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr_getNext_Private_Selectable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005E14 File Offset: 0x00004014
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1254457, RefRangeEnd = 1254460, XrefRangeStart = 1254445, XrefRangeEnd = 1254457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable getNext(Selectable current, bool isForward)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isForward;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr_getNext_Private_Selectable_Selectable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005E74 File Offset: 0x00004074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254460, XrefRangeEnd = 1254461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable GetNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr_GetNext_Public_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005EB4 File Offset: 0x000040B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254461, XrefRangeEnd = 1254462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable GetNext(Selectable current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr_GetNext_Public_Selectable_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005F04 File Offset: 0x00004104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254462, XrefRangeEnd = 1254463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable GetPrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr_GetPrevious_Public_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00005F44 File Offset: 0x00004144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254463, XrefRangeEnd = 1254464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable GetPrevious(Selectable current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr_GetPrevious_Public_Selectable_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005F94 File Offset: 0x00004194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1254474, RefRangeEnd = 1254476, XrefRangeStart = 1254464, XrefRangeEnd = 1254474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void select(Selectable next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr_select_Private_Void_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005FD8 File Offset: 0x000041D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1254509, RefRangeEnd = 1254510, XrefRangeStart = 1254476, XrefRangeEnd = 1254509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool shouldCheckAutomatic(Selectable sourceSelectable, MoveDirection navDirection, out Selectable foundSelectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceSelectable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref navDirection;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr_shouldCheckAutomatic_Private_Boolean_Selectable_MoveDirection_byref_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			foundSelectable = ((intPtr4 == 0) ? null : new Selectable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006058 File Offset: 0x00004258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1254510, XrefRangeEnd = 1254511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TabNavigation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabNavigation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabNavigation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000026D4 File Offset: 0x000008D4
		public TabNavigation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00006094 File Offset: 0x00004294
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000026DD File Offset: 0x000008DD
		public unsafe MoveDirection desiredDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabNavigation.NativeFieldInfoPtr_desiredDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabNavigation.NativeFieldInfoPtr_desiredDirection)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000060BC File Offset: 0x000042BC
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000026F8 File Offset: 0x000008F8
		public unsafe Selectable selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabNavigation.NativeFieldInfoPtr_selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabNavigation.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000060EC File Offset: 0x000042EC
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002717 File Offset: 0x00000917
		public unsafe EventSystem system
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabNavigation.NativeFieldInfoPtr_system);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabNavigation.NativeFieldInfoPtr_system), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000611C File Offset: 0x0000431C
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002736 File Offset: 0x00000936
		public unsafe bool wasSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabNavigation.NativeFieldInfoPtr_wasSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabNavigation.NativeFieldInfoPtr_wasSelected)) = value;
			}
		}

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_desiredDirection;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_selectable;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_system;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_wasSelected;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_getNext_Private_Selectable_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_getNext_Private_Selectable_Selectable_Boolean_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Public_Selectable_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Public_Selectable_Selectable_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_GetPrevious_Public_Selectable_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_GetPrevious_Public_Selectable_Selectable_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_select_Private_Void_Selectable_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_shouldCheckAutomatic_Private_Boolean_Selectable_MoveDirection_byref_Selectable_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
