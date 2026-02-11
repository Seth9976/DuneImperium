using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.input
{
	// Token: 0x0200001A RID: 26
	public class MouseButtonEvent : BubbleEvent
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0000A24C File Offset: 0x0000844C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseButtonEvent()
		{
			Il2CppClassPointerStore<MouseButtonEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.input", "MouseButtonEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseButtonEvent>.NativeClassPtr);
			MouseButtonEvent.NativeFieldInfoPtr_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseButtonEvent>.NativeClassPtr, "original");
			MouseButtonEvent.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseButtonEvent>.NativeClassPtr, "Button");
			MouseButtonEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseButtonEvent>.NativeClassPtr, 100663434);
			MouseButtonEvent.NativeMethodInfoPtr_get_OriginalSource_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseButtonEvent>.NativeClassPtr, 100663435);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000A2CC File Offset: 0x000084CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseButtonEvent(Transform originalSource, MouseButton button)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseButtonEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalSource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref button;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseButtonEvent.NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000A328 File Offset: 0x00008528
		public unsafe virtual Transform OriginalSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseButtonEvent.NativeMethodInfoPtr_get_OriginalSource_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000269E File Offset: 0x0000089E
		public MouseButtonEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000A368 File Offset: 0x00008568
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000026A7 File Offset: 0x000008A7
		public unsafe Transform original
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseButtonEvent.NativeFieldInfoPtr_original);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseButtonEvent.NativeFieldInfoPtr_original), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000A398 File Offset: 0x00008598
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000026C6 File Offset: 0x000008C6
		public unsafe MouseButton Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseButtonEvent.NativeFieldInfoPtr_Button);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseButtonEvent.NativeFieldInfoPtr_Button)) = value;
			}
		}

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_original;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_MouseButton_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalSource_Public_Virtual_Final_New_get_Transform_0;
	}
}
