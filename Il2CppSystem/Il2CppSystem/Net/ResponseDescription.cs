using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x02000199 RID: 409
	public class ResponseDescription : Object
	{
		// Token: 0x06001926 RID: 6438 RVA: 0x0007F148 File Offset: 0x0007D348
		// Note: this type is marked as 'beforefieldinit'.
		static ResponseDescription()
		{
			Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ResponseDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr);
			ResponseDescription.NativeFieldInfoPtr_Multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, "Multiline");
			ResponseDescription.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, "Status");
			ResponseDescription.NativeFieldInfoPtr_StatusDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, "StatusDescription");
			ResponseDescription.NativeFieldInfoPtr_StatusBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, "StatusBuffer");
			ResponseDescription.NativeFieldInfoPtr_StatusCodeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, "StatusCodeString");
			ResponseDescription.NativeMethodInfoPtr_get_PositiveIntermediate_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, 100667259);
			ResponseDescription.NativeMethodInfoPtr_get_PositiveCompletion_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, 100667260);
			ResponseDescription.NativeMethodInfoPtr_get_TransientFailure_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, 100667261);
			ResponseDescription.NativeMethodInfoPtr_get_PermanentFailure_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, 100667262);
			ResponseDescription.NativeMethodInfoPtr_get_InvalidStatusCode_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, 100667263);
			ResponseDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr, 100667264);
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x0007F254 File Offset: 0x0007D454
		public unsafe bool PositiveIntermediate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseDescription.NativeMethodInfoPtr_get_PositiveIntermediate_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0007F290 File Offset: 0x0007D490
		public unsafe bool PositiveCompletion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseDescription.NativeMethodInfoPtr_get_PositiveCompletion_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x0007F2CC File Offset: 0x0007D4CC
		public unsafe bool TransientFailure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseDescription.NativeMethodInfoPtr_get_TransientFailure_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0007F308 File Offset: 0x0007D508
		public unsafe bool PermanentFailure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseDescription.NativeMethodInfoPtr_get_PermanentFailure_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x0007F344 File Offset: 0x0007D544
		public unsafe bool InvalidStatusCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseDescription.NativeMethodInfoPtr_get_InvalidStatusCode_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0007F380 File Offset: 0x0007D580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471850, XrefRangeEnd = 471856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResponseDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResponseDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0000ABDF File Offset: 0x00008DDF
		public ResponseDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0007F3BC File Offset: 0x0007D5BC
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x0000ABE8 File Offset: 0x00008DE8
		public unsafe bool Multiline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResponseDescription.NativeFieldInfoPtr_Multiline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResponseDescription.NativeFieldInfoPtr_Multiline)) = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0007F3E4 File Offset: 0x0007D5E4
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x0000AC03 File Offset: 0x00008E03
		public unsafe int Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResponseDescription.NativeFieldInfoPtr_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResponseDescription.NativeFieldInfoPtr_Status)) = value;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0007F40C File Offset: 0x0007D60C
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0000AC1E File Offset: 0x00008E1E
		public unsafe string StatusDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResponseDescription.NativeFieldInfoPtr_StatusDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResponseDescription.NativeFieldInfoPtr_StatusDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0007F434 File Offset: 0x0007D634
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x0000AC3D File Offset: 0x00008E3D
		public unsafe StringBuilder StatusBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResponseDescription.NativeFieldInfoPtr_StatusBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResponseDescription.NativeFieldInfoPtr_StatusBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0007F464 File Offset: 0x0007D664
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0000AC5C File Offset: 0x00008E5C
		public unsafe string StatusCodeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResponseDescription.NativeFieldInfoPtr_StatusCodeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResponseDescription.NativeFieldInfoPtr_StatusCodeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeFieldInfoPtr_Multiline;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeFieldInfoPtr_StatusDescription;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeFieldInfoPtr_StatusBuffer;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeFieldInfoPtr_StatusCodeString;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeMethodInfoPtr_get_PositiveIntermediate_Internal_get_Boolean_0;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr_get_PositiveCompletion_Internal_get_Boolean_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_get_TransientFailure_Internal_get_Boolean_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_get_PermanentFailure_Internal_get_Boolean_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidStatusCode_Internal_get_Boolean_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
