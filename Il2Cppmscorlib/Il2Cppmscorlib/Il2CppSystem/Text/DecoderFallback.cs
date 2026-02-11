using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x020001FA RID: 506
	[Serializable]
	public class DecoderFallback : Object
	{
		// Token: 0x0600208C RID: 8332 RVA: 0x000BA28C File Offset: 0x000B848C
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderFallback()
		{
			Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr);
			DecoderFallback.NativeFieldInfoPtr_s_replacementFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "s_replacementFallback");
			DecoderFallback.NativeFieldInfoPtr_s_exceptionFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, "s_exceptionFallback");
			DecoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100668818);
			DecoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100668819);
			DecoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100668820);
			DecoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100668821);
			DecoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr, 100668822);
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x000BA348 File Offset: 0x000B8548
		public unsafe static DecoderFallback ReplacementFallback
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1362331, RefRangeEnd = 1362333, XrefRangeStart = 1362322, XrefRangeEnd = 1362331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x000BA37C File Offset: 0x000B857C
		public unsafe static DecoderFallback ExceptionFallback
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1362342, RefRangeEnd = 1362345, XrefRangeStart = 1362333, XrefRangeEnd = 1362342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x000BA3B0 File Offset: 0x000B85B0
		[CallerCount(0)]
		public unsafe virtual DecoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x000BA3FC File Offset: 0x000B85FC
		public unsafe virtual int MaxCharCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x000BA444 File Offset: 0x000B8644
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x0000A89A File Offset: 0x00008A9A
		public DecoderFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x000BA480 File Offset: 0x000B8680
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x0000A8A3 File Offset: 0x00008AA3
		public unsafe static DecoderFallback s_replacementFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecoderFallback.NativeFieldInfoPtr_s_replacementFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecoderFallback.NativeFieldInfoPtr_s_replacementFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x000BA4A8 File Offset: 0x000B86A8
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x0000A8B5 File Offset: 0x00008AB5
		public unsafe static DecoderFallback s_exceptionFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DecoderFallback.NativeFieldInfoPtr_s_exceptionFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecoderFallback.NativeFieldInfoPtr_s_exceptionFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeFieldInfoPtr_s_replacementFallback;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeFieldInfoPtr_s_exceptionFallback;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_DecoderFallback_0;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_DecoderFallback_0;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_DecoderFallbackBuffer_0;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
