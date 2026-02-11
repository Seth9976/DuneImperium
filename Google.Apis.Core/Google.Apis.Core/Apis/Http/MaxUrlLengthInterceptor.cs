using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Http
{
	// Token: 0x02000036 RID: 54
	public class MaxUrlLengthInterceptor : Object
	{
		// Token: 0x06000262 RID: 610 RVA: 0x0000CC4C File Offset: 0x0000AE4C
		// Note: this type is marked as 'beforefieldinit'.
		static MaxUrlLengthInterceptor()
		{
			Il2CppClassPointerStore<MaxUrlLengthInterceptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "MaxUrlLengthInterceptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaxUrlLengthInterceptor>.NativeClassPtr);
			MaxUrlLengthInterceptor.NativeFieldInfoPtr_maxUrlLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaxUrlLengthInterceptor>.NativeClassPtr, "maxUrlLength");
			MaxUrlLengthInterceptor.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxUrlLengthInterceptor>.NativeClassPtr, 100663658);
			MaxUrlLengthInterceptor.NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaxUrlLengthInterceptor>.NativeClassPtr, 100663659);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaxUrlLengthInterceptor(uint maxUrlLength)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaxUrlLengthInterceptor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxUrlLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxUrlLengthInterceptor.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000CD00 File Offset: 0x0000AF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1212433, XrefRangeEnd = 1212487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task InterceptAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaxUrlLengthInterceptor.NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002F9C File Offset: 0x0000119C
		public MaxUrlLengthInterceptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000CD68 File Offset: 0x0000AF68
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002FA5 File Offset: 0x000011A5
		public unsafe uint maxUrlLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxUrlLengthInterceptor.NativeFieldInfoPtr_maxUrlLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaxUrlLengthInterceptor.NativeFieldInfoPtr_maxUrlLength)) = value;
			}
		}

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_maxUrlLength;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0;
	}
}
