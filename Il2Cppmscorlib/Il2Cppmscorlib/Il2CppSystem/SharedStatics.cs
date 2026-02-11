using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Util;

namespace Il2CppSystem
{
	// Token: 0x02000139 RID: 313
	public sealed class SharedStatics : Object
	{
		// Token: 0x0600159F RID: 5535 RVA: 0x0008F09C File Offset: 0x0008D29C
		// Note: this type is marked as 'beforefieldinit'.
		static SharedStatics()
		{
			Il2CppClassPointerStore<SharedStatics>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SharedStatics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr);
			SharedStatics.NativeFieldInfoPtr__sharedStatics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, "_sharedStatics");
			SharedStatics.NativeFieldInfoPtr__maker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, "_maker");
			SharedStatics.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100667164);
			SharedStatics.NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100667165);
			SharedStatics.NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr, 100667166);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0008F130 File Offset: 0x0008D330
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SharedStatics()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedStatics>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatics.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0008F16C File Offset: 0x0008D36C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1343503, RefRangeEnd = 1343507, XrefRangeStart = 1343483, XrefRangeEnd = 1343503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tokenizer.StringMaker GetSharedStringMaker()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SharedStatics.NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr3) : null;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x0008F1A0 File Offset: 0x0008D3A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1343522, RefRangeEnd = 1343526, XrefRangeStart = 1343507, XrefRangeEnd = 1343522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(maker);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SharedStatics.NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				maker = ((intPtr4 == 0) ? null : new Tokenizer.StringMaker(intPtr4));
			}
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00006AAF File Offset: 0x00004CAF
		public SharedStatics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x0008F1EC File Offset: 0x0008D3EC
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x00006AB8 File Offset: 0x00004CB8
		public unsafe static SharedStatics _sharedStatics
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SharedStatics.NativeFieldInfoPtr__sharedStatics, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SharedStatics>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SharedStatics.NativeFieldInfoPtr__sharedStatics, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x0008F214 File Offset: 0x0008D414
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x00006ACA File Offset: 0x00004CCA
		public unsafe Tokenizer.StringMaker _maker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedStatics.NativeFieldInfoPtr__maker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SharedStatics.NativeFieldInfoPtr__maker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeFieldInfoPtr__sharedStatics;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeFieldInfoPtr__maker;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedStringMaker_Public_Static_StringMaker_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseSharedStringMaker_Public_Static_Void_byref_StringMaker_0;
	}
}
