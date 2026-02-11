using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000181 RID: 385
	[Serializable]
	public class AbandonedMutexException : SystemException
	{
		// Token: 0x060019D1 RID: 6609 RVA: 0x0009F6C0 File Offset: 0x0009D8C0
		// Note: this type is marked as 'beforefieldinit'.
		static AbandonedMutexException()
		{
			Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AbandonedMutexException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr);
			AbandonedMutexException.NativeFieldInfoPtr__mutexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, "_mutexIndex");
			AbandonedMutexException.NativeFieldInfoPtr__mutex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, "_mutex");
			AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100667820);
			AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_Int32_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100667821);
			AbandonedMutexException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100667822);
			AbandonedMutexException.NativeMethodInfoPtr_SetupException_Private_Void_Int32_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100667823);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0009F768 File Offset: 0x0009D968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1351473, RefRangeEnd = 1351474, XrefRangeStart = 1351470, XrefRangeEnd = 1351473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbandonedMutexException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0009F7A4 File Offset: 0x0009D9A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1351481, RefRangeEnd = 1351482, XrefRangeStart = 1351474, XrefRangeEnd = 1351481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbandonedMutexException(int location, WaitHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_Int32_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0009F800 File Offset: 0x0009DA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351482, XrefRangeEnd = 1351483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbandonedMutexException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0009F864 File Offset: 0x0009DA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351483, XrefRangeEnd = 1351487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupException(int location, WaitHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr_SetupException_Private_Void_Int32_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00008341 File Offset: 0x00006541
		public AbandonedMutexException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0009F8B4 File Offset: 0x0009DAB4
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x0000834A File Offset: 0x0000654A
		public unsafe int _mutexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr__mutexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr__mutexIndex)) = value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x0009F8DC File Offset: 0x0009DADC
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x00008365 File Offset: 0x00006565
		public unsafe Mutex _mutex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr__mutex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mutex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr__mutex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeFieldInfoPtr__mutexIndex;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeFieldInfoPtr__mutex;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_WaitHandle_0;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeMethodInfoPtr_SetupException_Private_Void_Int32_WaitHandle_0;
	}
}
