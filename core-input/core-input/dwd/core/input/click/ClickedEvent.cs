using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.input.click
{
	// Token: 0x020000A5 RID: 165
	public class ClickedEvent : UpEvent
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x0001FB34 File Offset: 0x0001DD34
		// Note: this type is marked as 'beforefieldinit'.
		static ClickedEvent()
		{
			Il2CppClassPointerStore<ClickedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.click", "ClickedEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickedEvent>.NativeClassPtr);
			ClickedEvent.NativeFieldInfoPtr__Consecutive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickedEvent>.NativeClassPtr, "<Consecutive>k__BackingField");
			ClickedEvent.NativeMethodInfoPtr_get_Consecutive_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickedEvent>.NativeClassPtr, 100664239);
			ClickedEvent.NativeMethodInfoPtr_set_Consecutive_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickedEvent>.NativeClassPtr, 100664240);
			ClickedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickedEvent>.NativeClassPtr, 100664241);
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x0001FBB4 File Offset: 0x0001DDB4
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		public unsafe int Consecutive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickedEvent.NativeMethodInfoPtr_get_Consecutive_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickedEvent.NativeMethodInfoPtr_set_Consecutive_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0001FC30 File Offset: 0x0001DE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126669, XrefRangeEnd = 1126670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickedEvent(Press press, Transform transform, int consecutive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickedEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref consecutive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClickedEvent.NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00005EF3 File Offset: 0x000040F3
		public ClickedEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0001FC9C File Offset: 0x0001DE9C
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x00005EFC File Offset: 0x000040FC
		public unsafe int _Consecutive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickedEvent.NativeFieldInfoPtr__Consecutive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClickedEvent.NativeFieldInfoPtr__Consecutive_k__BackingField)) = value;
			}
		}

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeFieldInfoPtr__Consecutive_k__BackingField;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_get_Consecutive_Public_get_Int32_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_set_Consecutive_Private_set_Void_Int32_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Press_Transform_Int32_0;
	}
}
