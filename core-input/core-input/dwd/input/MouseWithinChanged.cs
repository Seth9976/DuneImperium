using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.input
{
	// Token: 0x0200001E RID: 30
	public class MouseWithinChanged : DWDEvent
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x0000A4D4 File Offset: 0x000086D4
		// Note: this type is marked as 'beforefieldinit'.
		static MouseWithinChanged()
		{
			Il2CppClassPointerStore<MouseWithinChanged>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.input", "MouseWithinChanged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseWithinChanged>.NativeClassPtr);
			MouseWithinChanged.NativeFieldInfoPtr_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseWithinChanged>.NativeClassPtr, "original");
			MouseWithinChanged.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseWithinChanged>.NativeClassPtr, 100663439);
			MouseWithinChanged.NativeMethodInfoPtr_get_OriginalSource_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseWithinChanged>.NativeClassPtr, 100663440);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000A540 File Offset: 0x00008740
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseWithinChanged(Transform originalSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseWithinChanged>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseWithinChanged.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000A58C File Offset: 0x0000878C
		public unsafe virtual Transform OriginalSource
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseWithinChanged.NativeMethodInfoPtr_get_OriginalSource_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000027A7 File Offset: 0x000009A7
		public MouseWithinChanged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000A5CC File Offset: 0x000087CC
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000027B0 File Offset: 0x000009B0
		public unsafe Transform original
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseWithinChanged.NativeFieldInfoPtr_original);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseWithinChanged.NativeFieldInfoPtr_original), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_original;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalSource_Public_Virtual_Final_New_get_Transform_0;
	}
}
