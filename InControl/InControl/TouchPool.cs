using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace InControl
{
	// Token: 0x02000058 RID: 88
	public class TouchPool : Object
	{
		// Token: 0x060008C6 RID: 2246 RVA: 0x00026994 File Offset: 0x00024B94
		// Note: this type is marked as 'beforefieldinit'.
		static TouchPool()
		{
			Il2CppClassPointerStore<TouchPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "TouchPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchPool>.NativeClassPtr);
			TouchPool.NativeFieldInfoPtr_Touches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPool>.NativeClassPtr, "Touches");
			TouchPool.NativeFieldInfoPtr_usedTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPool>.NativeClassPtr, "usedTouches");
			TouchPool.NativeFieldInfoPtr_freeTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchPool>.NativeClassPtr, "freeTouches");
			TouchPool.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPool>.NativeClassPtr, 100664427);
			TouchPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPool>.NativeClassPtr, 100664428);
			TouchPool.NativeMethodInfoPtr_FindOrCreateTouch_Public_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPool>.NativeClassPtr, 100664429);
			TouchPool.NativeMethodInfoPtr_FindTouch_Public_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPool>.NativeClassPtr, 100664430);
			TouchPool.NativeMethodInfoPtr_NewTouch_Private_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPool>.NativeClassPtr, 100664431);
			TouchPool.NativeMethodInfoPtr_FreeTouch_Public_Void_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPool>.NativeClassPtr, 100664432);
			TouchPool.NativeMethodInfoPtr_FreeEndedTouches_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchPool>.NativeClassPtr, 100664433);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00026A8C File Offset: 0x00024C8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 786004, RefRangeEnd = 786006, XrefRangeStart = 785973, XrefRangeEnd = 786004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchPool(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPool>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPool.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00026AD4 File Offset: 0x00024CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786006, XrefRangeEnd = 786007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00026B10 File Offset: 0x00024D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786007, XrefRangeEnd = 786026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Touch FindOrCreateTouch(int fingerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fingerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPool.NativeMethodInfoPtr_FindOrCreateTouch_Public_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Touch>(intPtr3) : null;
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00026B5C File Offset: 0x00024D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786026, XrefRangeEnd = 786030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Touch FindTouch(int fingerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fingerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPool.NativeMethodInfoPtr_FindTouch_Public_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Touch>(intPtr3) : null;
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00026BA8 File Offset: 0x00024DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786030, XrefRangeEnd = 786037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Touch NewTouch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPool.NativeMethodInfoPtr_NewTouch_Private_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Touch>(intPtr3) : null;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00026BE8 File Offset: 0x00024DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786037, XrefRangeEnd = 786051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeTouch(Touch touch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(touch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPool.NativeMethodInfoPtr_FreeTouch_Public_Void_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00026C2C File Offset: 0x00024E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 786051, XrefRangeEnd = 786058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeEndedTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchPool.NativeMethodInfoPtr_FreeEndedTouches_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00005843 File Offset: 0x00003A43
		public TouchPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00026C60 File Offset: 0x00024E60
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x0000584C File Offset: 0x00003A4C
		public unsafe ReadOnlyCollection<Touch> Touches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPool.NativeFieldInfoPtr_Touches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Touch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPool.NativeFieldInfoPtr_Touches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00026C90 File Offset: 0x00024E90
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x0000586B File Offset: 0x00003A6B
		public unsafe List<Touch> usedTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPool.NativeFieldInfoPtr_usedTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Touch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPool.NativeFieldInfoPtr_usedTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00026CC0 File Offset: 0x00024EC0
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x0000588A File Offset: 0x00003A8A
		public unsafe List<Touch> freeTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPool.NativeFieldInfoPtr_freeTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Touch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchPool.NativeFieldInfoPtr_freeTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_Touches;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_usedTouches;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeFieldInfoPtr_freeTouches;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateTouch_Public_Touch_Int32_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_FindTouch_Public_Touch_Int32_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_NewTouch_Private_Touch_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_FreeTouch_Public_Void_Touch_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_FreeEndedTouches_Public_Void_0;
	}
}
