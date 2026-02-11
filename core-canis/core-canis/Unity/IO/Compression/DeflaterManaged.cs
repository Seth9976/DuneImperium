using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.IO.Compression
{
	// Token: 0x02000068 RID: 104
	public class DeflaterManaged : Object
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x00030B2C File Offset: 0x0002ED2C
		// Note: this type is marked as 'beforefieldinit'.
		static DeflaterManaged()
		{
			Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "DeflaterManaged");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr);
			DeflaterManaged.NativeFieldInfoPtr_MinBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, "MinBlockSize");
			DeflaterManaged.NativeFieldInfoPtr_MaxHeaderFooterGoo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, "MaxHeaderFooterGoo");
			DeflaterManaged.NativeFieldInfoPtr_CleanCopySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, "CleanCopySize");
			DeflaterManaged.NativeFieldInfoPtr_BadCompressionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, "BadCompressionThreshold");
			DeflaterManaged.NativeFieldInfoPtr_deflateEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, "deflateEncoder");
			DeflaterManaged.NativeFieldInfoPtr_copyEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, "copyEncoder");
			DeflaterManaged.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, "input");
			DeflaterManaged.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, "output");
			DeflaterManaged.NativeFieldInfoPtr_processingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, "processingState");
			DeflaterManaged.NativeFieldInfoPtr_inputFromHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, "inputFromHistory");
			DeflaterManaged.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664398);
			DeflaterManaged.NativeMethodInfoPtr_NeedsInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664399);
			DeflaterManaged.NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_NeedsInput_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664400);
			DeflaterManaged.NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_SetInput_Private_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664401);
			DeflaterManaged.NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_GetDeflateOutput_Private_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664402);
			DeflaterManaged.NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_Finish_Private_Virtual_Final_New_Boolean_Il2CppStructArray_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664403);
			DeflaterManaged.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664404);
			DeflaterManaged.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664405);
			DeflaterManaged.NativeMethodInfoPtr_UseCompressed_Private_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664406);
			DeflaterManaged.NativeMethodInfoPtr_FlushInputWindows_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664407);
			DeflaterManaged.NativeMethodInfoPtr_WriteFinal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr, 100664408);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00030D00 File Offset: 0x0002EF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860692, XrefRangeEnd = 860724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeflaterManaged()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflaterManaged>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00030D3C File Offset: 0x0002EF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860724, XrefRangeEnd = 860727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NeedsInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr_NeedsInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00030D78 File Offset: 0x0002EF78
		[CallerCount(0)]
		public unsafe virtual bool Unity_IO_Compression_IDeflater_NeedsInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_NeedsInput_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00030DB4 File Offset: 0x0002EFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860727, XrefRangeEnd = 860728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unity_IO_Compression_IDeflater_SetInput(Il2CppStructArray<byte> inputBuffer, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_SetInput_Private_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00030E14 File Offset: 0x0002F014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860728, XrefRangeEnd = 860740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Unity_IO_Compression_IDeflater_GetDeflateOutput(Il2CppStructArray<byte> outputBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_GetDeflateOutput_Private_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00030E64 File Offset: 0x0002F064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860740, XrefRangeEnd = 860747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Unity_IO_Compression_IDeflater_Finish(Il2CppStructArray<byte> outputBuffer, out int bytesRead)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_Finish_Private_Virtual_Final_New_Boolean_Il2CppStructArray_1_Byte_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00030EC0 File Offset: 0x0002F0C0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00030EF4 File Offset: 0x0002F0F4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00030F34 File Offset: 0x0002F134
		[CallerCount(0)]
		public unsafe bool UseCompressed(double ratio)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ratio;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr_UseCompressed_Private_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00030F80 File Offset: 0x0002F180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860747, XrefRangeEnd = 860749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushInputWindows()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr_FlushInputWindows_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00030FB4 File Offset: 0x0002F1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860749, XrefRangeEnd = 860750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflaterManaged.NativeMethodInfoPtr_WriteFinal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000044EC File Offset: 0x000026EC
		public DeflaterManaged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00030FE8 File Offset: 0x0002F1E8
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000044F5 File Offset: 0x000026F5
		public unsafe static int MinBlockSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeflaterManaged.NativeFieldInfoPtr_MinBlockSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeflaterManaged.NativeFieldInfoPtr_MinBlockSize, (void*)(&value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00031004 File Offset: 0x0002F204
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00004503 File Offset: 0x00002703
		public unsafe static int MaxHeaderFooterGoo
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeflaterManaged.NativeFieldInfoPtr_MaxHeaderFooterGoo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeflaterManaged.NativeFieldInfoPtr_MaxHeaderFooterGoo, (void*)(&value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00031020 File Offset: 0x0002F220
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00004511 File Offset: 0x00002711
		public unsafe static int CleanCopySize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DeflaterManaged.NativeFieldInfoPtr_CleanCopySize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeflaterManaged.NativeFieldInfoPtr_CleanCopySize, (void*)(&value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0003103C File Offset: 0x0002F23C
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x0000451F File Offset: 0x0000271F
		public unsafe static double BadCompressionThreshold
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(DeflaterManaged.NativeFieldInfoPtr_BadCompressionThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeflaterManaged.NativeFieldInfoPtr_BadCompressionThreshold, (void*)(&value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00031058 File Offset: 0x0002F258
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x0000452D File Offset: 0x0000272D
		public unsafe FastEncoder deflateEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_deflateEncoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastEncoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_deflateEncoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00031088 File Offset: 0x0002F288
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x0000454C File Offset: 0x0000274C
		public unsafe CopyEncoder copyEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_copyEncoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyEncoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_copyEncoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x000310B8 File Offset: 0x0002F2B8
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x0000456B File Offset: 0x0000276B
		public unsafe DeflateInput input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeflateInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x000310E8 File Offset: 0x0002F2E8
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x0000458A File Offset: 0x0000278A
		public unsafe OutputBuffer output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OutputBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00031118 File Offset: 0x0002F318
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x000045A9 File Offset: 0x000027A9
		public unsafe DeflaterManaged.DeflaterState processingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_processingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_processingState)) = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00031140 File Offset: 0x0002F340
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x000045C4 File Offset: 0x000027C4
		public unsafe DeflateInput inputFromHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_inputFromHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeflateInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflaterManaged.NativeFieldInfoPtr_inputFromHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeFieldInfoPtr_MinBlockSize;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_MaxHeaderFooterGoo;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_CleanCopySize;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_BadCompressionThreshold;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr_deflateEncoder;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr_copyEncoder;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr_processingState;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr_inputFromHistory;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_NeedsInput_Private_Boolean_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_NeedsInput_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_SetInput_Private_Virtual_Final_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_GetDeflateOutput_Private_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_Unity_IO_Compression_IDeflater_Finish_Private_Virtual_Final_New_Boolean_Il2CppStructArray_1_Byte_byref_Int32_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_UseCompressed_Private_Boolean_Double_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_FlushInputWindows_Private_Void_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_WriteFinal_Private_Void_0;

		// Token: 0x0200027F RID: 639
		public enum DeflaterState
		{
			// Token: 0x040015AE RID: 5550
			NotStarted,
			// Token: 0x040015AF RID: 5551
			SlowDownForIncompressible1,
			// Token: 0x040015B0 RID: 5552
			SlowDownForIncompressible2,
			// Token: 0x040015B1 RID: 5553
			StartingSmallData,
			// Token: 0x040015B2 RID: 5554
			CompressThenCheck,
			// Token: 0x040015B3 RID: 5555
			CheckingForIncompressible,
			// Token: 0x040015B4 RID: 5556
			HandlingSmallData
		}
	}
}
