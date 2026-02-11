using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200025F RID: 607
	public class OpacityIdAccelerator : Object
	{
		// Token: 0x06002CA2 RID: 11426 RVA: 0x000C02CC File Offset: 0x000BE4CC
		// Note: this type is marked as 'beforefieldinit'.
		static OpacityIdAccelerator()
		{
			Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "OpacityIdAccelerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr);
			OpacityIdAccelerator.NativeFieldInfoPtr_m_Jobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, "m_Jobs");
			OpacityIdAccelerator.NativeFieldInfoPtr_m_NextJobIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, "m_NextJobIndex");
			OpacityIdAccelerator.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, "<disposed>k__BackingField");
			OpacityIdAccelerator.NativeMethodInfoPtr_CreateJob_Public_Void_NativeSlice_1_Vertex_NativeSlice_1_Vertex_Color32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, 100669881);
			OpacityIdAccelerator.NativeMethodInfoPtr_CompleteJobs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, 100669882);
			OpacityIdAccelerator.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, 100669883);
			OpacityIdAccelerator.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, 100669884);
			OpacityIdAccelerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, 100669885);
			OpacityIdAccelerator.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, 100669886);
			OpacityIdAccelerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, 100669887);
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x000C03C4 File Offset: 0x000BE5C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350512, RefRangeEnd = 350513, XrefRangeStart = 350507, XrefRangeEnd = 350512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateJob(NativeSlice<Vertex> oldVerts, NativeSlice<Vertex> newVerts, Color32 opacityData, int vertexCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(oldVerts));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newVerts));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opacityData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertexCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpacityIdAccelerator.NativeMethodInfoPtr_CreateJob_Public_Void_NativeSlice_1_Vertex_NativeSlice_1_Vertex_Color32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000C0440 File Offset: 0x000BE640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350513, XrefRangeEnd = 350519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteJobs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpacityIdAccelerator.NativeMethodInfoPtr_CompleteJobs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x000C0474 File Offset: 0x000BE674
		// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x000C04B0 File Offset: 0x000BE6B0
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpacityIdAccelerator.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpacityIdAccelerator.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x000C04F0 File Offset: 0x000BE6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350519, XrefRangeEnd = 350523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpacityIdAccelerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000C0524 File Offset: 0x000BE724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350523, XrefRangeEnd = 350526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OpacityIdAccelerator.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x000C0570 File Offset: 0x000BE770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350526, XrefRangeEnd = 350530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpacityIdAccelerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpacityIdAccelerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x00012221 File Offset: 0x00010421
		public OpacityIdAccelerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x000C05AC File Offset: 0x000BE7AC
		// (set) Token: 0x06002CAC RID: 11436 RVA: 0x0001222A File Offset: 0x0001042A
		public NativeArray<JobHandle> m_Jobs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.NativeFieldInfoPtr_m_Jobs);
				return new NativeArray<JobHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<JobHandle>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.NativeFieldInfoPtr_m_Jobs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<JobHandle>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x000C05DC File Offset: 0x000BE7DC
		// (set) Token: 0x06002CAE RID: 11438 RVA: 0x00012258 File Offset: 0x00010458
		public unsafe int m_NextJobIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.NativeFieldInfoPtr_m_NextJobIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.NativeFieldInfoPtr_m_NextJobIndex)) = value;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x000C0604 File Offset: 0x000BE804
		// (set) Token: 0x06002CB0 RID: 11440 RVA: 0x00012273 File Offset: 0x00010473
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeFieldInfoPtr_m_Jobs;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeFieldInfoPtr_m_NextJobIndex;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeMethodInfoPtr_CreateJob_Public_Void_NativeSlice_1_Vertex_NativeSlice_1_Vertex_Color32_Int32_0;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeMethodInfoPtr_CompleteJobs_Public_Void_0;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002002 RID: 8194
		public const int k_VerticesPerBatch = 128;

		// Token: 0x04002003 RID: 8195
		public const int k_JobLimit = 256;

		// Token: 0x02000551 RID: 1361
		public sealed class OpacityIdUpdateJob : ValueType
		{
			// Token: 0x0600418B RID: 16779 RVA: 0x001028EC File Offset: 0x00100AEC
			// Note: this type is marked as 'beforefieldinit'.
			static OpacityIdUpdateJob()
			{
				Il2CppClassPointerStore<OpacityIdAccelerator.OpacityIdUpdateJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OpacityIdAccelerator>.NativeClassPtr, "OpacityIdUpdateJob");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpacityIdAccelerator.OpacityIdUpdateJob>.NativeClassPtr);
				OpacityIdAccelerator.OpacityIdUpdateJob.NativeFieldInfoPtr_oldVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpacityIdAccelerator.OpacityIdUpdateJob>.NativeClassPtr, "oldVerts");
				OpacityIdAccelerator.OpacityIdUpdateJob.NativeFieldInfoPtr_newVerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpacityIdAccelerator.OpacityIdUpdateJob>.NativeClassPtr, "newVerts");
				OpacityIdAccelerator.OpacityIdUpdateJob.NativeFieldInfoPtr_opacityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpacityIdAccelerator.OpacityIdUpdateJob>.NativeClassPtr, "opacityData");
				OpacityIdAccelerator.OpacityIdUpdateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpacityIdAccelerator.OpacityIdUpdateJob>.NativeClassPtr, 100669888);
			}

			// Token: 0x0600418C RID: 16780 RVA: 0x00102968 File Offset: 0x00100B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350501, XrefRangeEnd = 350507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Execute(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpacityIdAccelerator.OpacityIdUpdateJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600418D RID: 16781 RVA: 0x0001BCBE File Offset: 0x00019EBE
			public OpacityIdUpdateJob(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600418E RID: 16782 RVA: 0x0001BCC7 File Offset: 0x00019EC7
			public OpacityIdUpdateJob()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpacityIdAccelerator.OpacityIdUpdateJob>.NativeClassPtr))
			{
			}

			// Token: 0x170013A5 RID: 5029
			// (get) Token: 0x0600418F RID: 16783 RVA: 0x001029AC File Offset: 0x00100BAC
			// (set) Token: 0x06004190 RID: 16784 RVA: 0x0001BCD9 File Offset: 0x00019ED9
			public NativeSlice<Vertex> oldVerts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.OpacityIdUpdateJob.NativeFieldInfoPtr_oldVerts);
					return new NativeSlice<Vertex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<Vertex>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.OpacityIdUpdateJob.NativeFieldInfoPtr_oldVerts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<Vertex>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170013A6 RID: 5030
			// (get) Token: 0x06004191 RID: 16785 RVA: 0x001029DC File Offset: 0x00100BDC
			// (set) Token: 0x06004192 RID: 16786 RVA: 0x0001BD07 File Offset: 0x00019F07
			public NativeSlice<Vertex> newVerts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.OpacityIdUpdateJob.NativeFieldInfoPtr_newVerts);
					return new NativeSlice<Vertex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeSlice<Vertex>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.OpacityIdUpdateJob.NativeFieldInfoPtr_newVerts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeSlice<Vertex>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170013A7 RID: 5031
			// (get) Token: 0x06004193 RID: 16787 RVA: 0x00102A0C File Offset: 0x00100C0C
			// (set) Token: 0x06004194 RID: 16788 RVA: 0x0001BD35 File Offset: 0x00019F35
			public unsafe Color32 opacityData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.OpacityIdUpdateJob.NativeFieldInfoPtr_opacityData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpacityIdAccelerator.OpacityIdUpdateJob.NativeFieldInfoPtr_opacityData)) = value;
				}
			}

			// Token: 0x04002E0E RID: 11790
			private static readonly IntPtr NativeFieldInfoPtr_oldVerts;

			// Token: 0x04002E0F RID: 11791
			private static readonly IntPtr NativeFieldInfoPtr_newVerts;

			// Token: 0x04002E10 RID: 11792
			private static readonly IntPtr NativeFieldInfoPtr_opacityData;

			// Token: 0x04002E11 RID: 11793
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;
		}
	}
}
