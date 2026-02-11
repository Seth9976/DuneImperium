using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000197 RID: 407
	[StructLayout(2)]
	public struct SpinWait
	{
		// Token: 0x06001A7F RID: 6783 RVA: 0x000A2030 File Offset: 0x000A0230
		// Note: this type is marked as 'beforefieldinit'.
		static SpinWait()
		{
			Il2CppClassPointerStore<SpinWait>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SpinWait");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpinWait>.NativeClassPtr);
			SpinWait.NativeFieldInfoPtr_SpinCountforSpinBeforeWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, "SpinCountforSpinBeforeWait");
			SpinWait.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, "_count");
			SpinWait.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100667905);
			SpinWait.NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100667906);
			SpinWait.NativeMethodInfoPtr_SpinOnce_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100667907);
			SpinWait.NativeMethodInfoPtr_SpinOnce_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100667908);
			SpinWait.NativeMethodInfoPtr_SpinOnceCore_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, 100667909);
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x000A20EC File Offset: 0x000A02EC
		public unsafe int Count
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinWait.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x000A211C File Offset: 0x000A031C
		public unsafe bool NextSpinWillYield
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352197, XrefRangeEnd = 1352198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinWait.NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000A214C File Offset: 0x000A034C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1352202, RefRangeEnd = 1352213, XrefRangeStart = 1352198, XrefRangeEnd = 1352202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpinOnce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinWait.NativeMethodInfoPtr_SpinOnce_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000A2174 File Offset: 0x000A0374
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1352232, RefRangeEnd = 1352234, XrefRangeStart = 1352213, XrefRangeEnd = 1352232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpinOnce(int sleep1Threshold)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sleep1Threshold;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinWait.NativeMethodInfoPtr_SpinOnce_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000A21A8 File Offset: 0x000A03A8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1352254, RefRangeEnd = 1352262, XrefRangeStart = 1352234, XrefRangeEnd = 1352254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpinOnceCore(int sleep1Threshold)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sleep1Threshold;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpinWait.NativeMethodInfoPtr_SpinOnceCore_Private_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00008712 File Offset: 0x00006912
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpinWait>.NativeClassPtr, ref this));
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x000A21DC File Offset: 0x000A03DC
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x00008724 File Offset: 0x00006924
		public unsafe static int SpinCountforSpinBeforeWait
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SpinWait.NativeFieldInfoPtr_SpinCountforSpinBeforeWait, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpinWait.NativeFieldInfoPtr_SpinCountforSpinBeforeWait, (void*)(&value));
			}
		}

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeFieldInfoPtr_SpinCountforSpinBeforeWait;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSpinWillYield_Public_get_Boolean_0;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_SpinOnce_Public_Void_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_SpinOnce_Public_Void_Int32_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr_SpinOnceCore_Private_Void_Int32_0;

		// Token: 0x04001881 RID: 6273
		[FieldOffset(0)]
		public int _count;
	}
}
