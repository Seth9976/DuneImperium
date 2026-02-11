using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000242 RID: 578
	[StructLayout(2)]
	public struct RenderQueueRange
	{
		// Token: 0x060026C5 RID: 9925 RVA: 0x000A4084 File Offset: 0x000A2284
		// Note: this type is marked as 'beforefieldinit'.
		static RenderQueueRange()
		{
			Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderQueueRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr);
			RenderQueueRange.NativeFieldInfoPtr_m_LowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "m_LowerBound");
			RenderQueueRange.NativeFieldInfoPtr_m_UpperBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "m_UpperBound");
			RenderQueueRange.NativeFieldInfoPtr_k_MinimumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "k_MinimumBound");
			RenderQueueRange.NativeFieldInfoPtr_minimumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "minimumBound");
			RenderQueueRange.NativeFieldInfoPtr_k_MaximumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "k_MaximumBound");
			RenderQueueRange.NativeFieldInfoPtr_maximumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, "maximumBound");
			RenderQueueRange.NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668265);
			RenderQueueRange.NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668266);
			RenderQueueRange.NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668267);
			RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668268);
			RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668269);
			RenderQueueRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668270);
			RenderQueueRange.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderQueueRange_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100668271);
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x000A41B8 File Offset: 0x000A23B8
		public unsafe static RenderQueueRange all
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 684298, RefRangeEnd = 684303, XrefRangeStart = 684298, XrefRangeEnd = 684298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000A41E8 File Offset: 0x000A23E8
		public unsafe static RenderQueueRange opaque
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 684303, RefRangeEnd = 684317, XrefRangeStart = 684303, XrefRangeEnd = 684303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x000A4218 File Offset: 0x000A2418
		public unsafe static RenderQueueRange transparent
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 684317, RefRangeEnd = 684320, XrefRangeStart = 684317, XrefRangeEnd = 684317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x000A4248 File Offset: 0x000A2448
		[CallerCount(0)]
		public unsafe bool Equals(RenderQueueRange other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x000A4288 File Offset: 0x000A2488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684320, XrefRangeEnd = 684325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x000A42CC File Offset: 0x000A24CC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x000A42FC File Offset: 0x000A24FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 684328, RefRangeEnd = 684332, XrefRangeStart = 684325, XrefRangeEnd = 684328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RenderQueueRange left, RenderQueueRange right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderQueueRange_RenderQueueRange_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0000F2E2 File Offset: 0x0000D4E2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, ref this));
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x000A4348 File Offset: 0x000A2548
		// (set) Token: 0x060026CF RID: 9935 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		public unsafe static int k_MinimumBound
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_k_MinimumBound, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_k_MinimumBound, (void*)(&value));
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x000A4364 File Offset: 0x000A2564
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x0000F302 File Offset: 0x0000D502
		public unsafe static int minimumBound
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_minimumBound, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_minimumBound, (void*)(&value));
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x000A4380 File Offset: 0x000A2580
		// (set) Token: 0x060026D3 RID: 9939 RVA: 0x0000F310 File Offset: 0x0000D510
		public unsafe static int k_MaximumBound
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_k_MaximumBound, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_k_MaximumBound, (void*)(&value));
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x000A439C File Offset: 0x000A259C
		// (set) Token: 0x060026D5 RID: 9941 RVA: 0x0000F31E File Offset: 0x0000D51E
		public unsafe static int maximumBound
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_maximumBound, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_maximumBound, (void*)(&value));
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060026D6 RID: 9942 RVA: 0x000A43B8 File Offset: 0x000A25B8
		// (set) Token: 0x060026D7 RID: 9943 RVA: 0x000A43D0 File Offset: 0x000A25D0
		public int lowerBound
		{
			get
			{
				return this.m_LowerBound;
			}
			set
			{
				bool flag = value < 0 || value > 5000;
				if (flag)
				{
					throw new ArgumentOutOfRangeException(String.Format("The lower bound must be at least {0} and at most {1}.", 0, 5000));
				}
				this.m_LowerBound = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x000A4418 File Offset: 0x000A2618
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x000A4430 File Offset: 0x000A2630
		public int upperBound
		{
			get
			{
				return this.m_UpperBound;
			}
			set
			{
				bool flag = value < 0 || value > 5000;
				if (flag)
				{
					throw new ArgumentOutOfRangeException(String.Format("The upper bound must be at least {0} and at most {1}.", 0, 5000));
				}
				this.m_UpperBound = value;
			}
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x000A4478 File Offset: 0x000A2678
		public static bool operator !=(RenderQueueRange left, RenderQueueRange right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeFieldInfoPtr_m_LowerBound;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeFieldInfoPtr_m_UpperBound;

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeFieldInfoPtr_k_MinimumBound;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeFieldInfoPtr_minimumBound;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumBound;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeFieldInfoPtr_maximumBound;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0;

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderQueueRange_RenderQueueRange_0;

		// Token: 0x040022A8 RID: 8872
		[FieldOffset(0)]
		public int m_LowerBound;

		// Token: 0x040022A9 RID: 8873
		[FieldOffset(4)]
		public int m_UpperBound;
	}
}
