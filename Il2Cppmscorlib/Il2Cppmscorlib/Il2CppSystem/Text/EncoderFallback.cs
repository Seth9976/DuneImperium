using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000205 RID: 517
	[Serializable]
	public class EncoderFallback : Object
	{
		// Token: 0x06002127 RID: 8487 RVA: 0x000BCCF0 File Offset: 0x000BAEF0
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderFallback()
		{
			Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr);
			EncoderFallback.NativeFieldInfoPtr_s_replacementFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "s_replacementFallback");
			EncoderFallback.NativeFieldInfoPtr_s_exceptionFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, "s_exceptionFallback");
			EncoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100668901);
			EncoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100668902);
			EncoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100668903);
			EncoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100668904);
			EncoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr, 100668905);
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x000BCDAC File Offset: 0x000BAFAC
		public unsafe static EncoderFallback ReplacementFallback
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1362782, RefRangeEnd = 1362783, XrefRangeStart = 1362771, XrefRangeEnd = 1362782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x000BCDE0 File Offset: 0x000BAFE0
		public unsafe static EncoderFallback ExceptionFallback
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1362792, RefRangeEnd = 1362795, XrefRangeStart = 1362783, XrefRangeEnd = 1362792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x000BCE14 File Offset: 0x000BB014
		[CallerCount(0)]
		public unsafe virtual EncoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x000BCE60 File Offset: 0x000BB060
		public unsafe virtual int MaxCharCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000BCEA8 File Offset: 0x000BB0A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallback.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x0000ABA5 File Offset: 0x00008DA5
		public EncoderFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x000BCEE4 File Offset: 0x000BB0E4
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x0000ABAE File Offset: 0x00008DAE
		public unsafe static EncoderFallback s_replacementFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncoderFallback.NativeFieldInfoPtr_s_replacementFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncoderFallback.NativeFieldInfoPtr_s_replacementFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x000BCF0C File Offset: 0x000BB10C
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		public unsafe static EncoderFallback s_exceptionFallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncoderFallback.NativeFieldInfoPtr_s_exceptionFallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncoderFallback.NativeFieldInfoPtr_s_exceptionFallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeFieldInfoPtr_s_replacementFallback;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeFieldInfoPtr_s_exceptionFallback;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_get_ReplacementFallback_Public_Static_get_EncoderFallback_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr_get_ExceptionFallback_Public_Static_get_EncoderFallback_0;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Abstract_Virtual_New_EncoderFallbackBuffer_0;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
