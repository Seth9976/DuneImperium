using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200019C RID: 412
	public sealed class CancellationCallbackCoreWorkArguments : ValueType
	{
		// Token: 0x06001AE1 RID: 6881 RVA: 0x000A348C File Offset: 0x000A168C
		// Note: this type is marked as 'beforefieldinit'.
		static CancellationCallbackCoreWorkArguments()
		{
			Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "CancellationCallbackCoreWorkArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr);
			CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr__currArrayFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, "_currArrayFragment");
			CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr__currArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, "_currArrayIndex");
			CancellationCallbackCoreWorkArguments.NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr, 100667962);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x000A34F8 File Offset: 0x000A16F8
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 336243, RefRangeEnd = 336283, XrefRangeStart = 336243, XrefRangeEnd = 336283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currArrayFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currArrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CancellationCallbackCoreWorkArguments.NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00008935 File Offset: 0x00006B35
		public CancellationCallbackCoreWorkArguments(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0000893E File Offset: 0x00006B3E
		public CancellationCallbackCoreWorkArguments()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CancellationCallbackCoreWorkArguments>.NativeClassPtr))
		{
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x000A3558 File Offset: 0x000A1758
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x00008950 File Offset: 0x00006B50
		public unsafe SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr__currArrayFragment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<CancellationCallbackInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr__currArrayFragment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x000A3588 File Offset: 0x000A1788
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x0000896F File Offset: 0x00006B6F
		public unsafe int _currArrayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr__currArrayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CancellationCallbackCoreWorkArguments.NativeFieldInfoPtr__currArrayIndex)) = value;
			}
		}

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeFieldInfoPtr__currArrayFragment;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeFieldInfoPtr__currArrayIndex;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SparselyPopulatedArrayFragment_1_CancellationCallbackInfo_Int32_0;
	}
}
