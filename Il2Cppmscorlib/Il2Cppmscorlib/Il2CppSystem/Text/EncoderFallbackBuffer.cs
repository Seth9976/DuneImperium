using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000206 RID: 518
	public class EncoderFallbackBuffer : Object
	{
		// Token: 0x06002132 RID: 8498 RVA: 0x000BCF34 File Offset: 0x000BB134
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderFallbackBuffer()
		{
			Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr);
			EncoderFallbackBuffer.NativeFieldInfoPtr_charStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "charStart");
			EncoderFallbackBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "charEnd");
			EncoderFallbackBuffer.NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "encoder");
			EncoderFallbackBuffer.NativeFieldInfoPtr_setEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "setEncoder");
			EncoderFallbackBuffer.NativeFieldInfoPtr_bUsedEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "bUsedEncoder");
			EncoderFallbackBuffer.NativeFieldInfoPtr_bFallingBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "bFallingBack");
			EncoderFallbackBuffer.NativeFieldInfoPtr_iRecursionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "iRecursionCount");
			EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668906);
			EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668907);
			EncoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668908);
			EncoderFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668909);
			EncoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668910);
			EncoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668911);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalReset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668912);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Char_ptr_Char_EncoderNLS_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668913);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalGetNextChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668914);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Char_byref_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668915);
			EncoderFallbackBuffer.NativeMethodInfoPtr_ThrowLastCharRecursive_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668916);
			EncoderFallbackBuffer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100668917);
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x000BD0E0 File Offset: 0x000BB2E0
		[CallerCount(0)]
		public unsafe virtual bool Fallback(char charUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknown;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x000BD144 File Offset: 0x000BB344
		[CallerCount(0)]
		public unsafe virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknownHigh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x000BD1B4 File Offset: 0x000BB3B4
		[CallerCount(0)]
		public unsafe virtual char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x000BD1FC File Offset: 0x000BB3FC
		[CallerCount(0)]
		public unsafe virtual bool MovePrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x000BD244 File Offset: 0x000BB444
		public unsafe virtual int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x000BD28C File Offset: 0x000BB48C
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x000BD2C8 File Offset: 0x000BB4C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1362795, RefRangeEnd = 1362796, XrefRangeStart = 1362795, XrefRangeEnd = 1362795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_InternalReset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x000BD2FC File Offset: 0x000BB4FC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1362797, RefRangeEnd = 1362809, XrefRangeStart = 1362796, XrefRangeEnd = 1362797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = charStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = charEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setEncoder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Char_ptr_Char_EncoderNLS_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x000BD368 File Offset: 0x000BB568
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1362809, RefRangeEnd = 1362812, XrefRangeStart = 1362809, XrefRangeEnd = 1362809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char InternalGetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_InternalGetNextChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x000BD3A4 File Offset: 0x000BB5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362812, XrefRangeEnd = 1362821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool InternalFallback(char ch, ref char* chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Char_byref_ptr_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chars = ((intPtr4 == 0) ? null : new char*(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x000BD424 File Offset: 0x000BB624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362821, XrefRangeEnd = 1362831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowLastCharRecursive(int charRecursive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charRecursive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_ThrowLastCharRecursive_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x000BD464 File Offset: 0x000BB664
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0000ABD2 File Offset: 0x00008DD2
		public EncoderFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x000BD4A0 File Offset: 0x000BB6A0
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x0000ABDB File Offset: 0x00008DDB
		public unsafe char* charStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charStart)) = value;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x000BD4C4 File Offset: 0x000BB6C4
		// (set) Token: 0x06002143 RID: 8515 RVA: 0x0000ABF6 File Offset: 0x00008DF6
		public unsafe char* charEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charEnd)) = value;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x000BD4E8 File Offset: 0x000BB6E8
		// (set) Token: 0x06002145 RID: 8517 RVA: 0x0000AC11 File Offset: 0x00008E11
		public unsafe EncoderNLS encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderNLS>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002146 RID: 8518 RVA: 0x000BD518 File Offset: 0x000BB718
		// (set) Token: 0x06002147 RID: 8519 RVA: 0x0000AC30 File Offset: 0x00008E30
		public unsafe bool setEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_setEncoder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_setEncoder)) = value;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x000BD540 File Offset: 0x000BB740
		// (set) Token: 0x06002149 RID: 8521 RVA: 0x0000AC4B File Offset: 0x00008E4B
		public unsafe bool bUsedEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bUsedEncoder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bUsedEncoder)) = value;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x000BD568 File Offset: 0x000BB768
		// (set) Token: 0x0600214B RID: 8523 RVA: 0x0000AC66 File Offset: 0x00008E66
		public unsafe bool bFallingBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bFallingBack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bFallingBack)) = value;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600214C RID: 8524 RVA: 0x000BD590 File Offset: 0x000BB790
		// (set) Token: 0x0600214D RID: 8525 RVA: 0x0000AC81 File Offset: 0x00008E81
		public unsafe int iRecursionCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_iRecursionCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_iRecursionCount)) = value;
			}
		}

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeFieldInfoPtr_charStart;

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeFieldInfoPtr_charEnd;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeFieldInfoPtr_encoder;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeFieldInfoPtr_setEncoder;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeFieldInfoPtr_bUsedEncoder;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeFieldInfoPtr_bFallingBack;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeFieldInfoPtr_iRecursionCount;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Int32_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Char_Int32_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_InternalReset_Internal_Void_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Char_ptr_Char_EncoderNLS_Boolean_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetNextChar_Internal_Char_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Char_byref_ptr_Char_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_ThrowLastCharRecursive_Internal_Void_Int32_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
