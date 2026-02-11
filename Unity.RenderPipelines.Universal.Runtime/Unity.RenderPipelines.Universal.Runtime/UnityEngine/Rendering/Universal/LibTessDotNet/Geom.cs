using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x02000109 RID: 265
	public static class Geom : Object
	{
		// Token: 0x06001635 RID: 5685 RVA: 0x0005F2FC File Offset: 0x0005D4FC
		// Note: this type is marked as 'beforefieldinit'.
		static Geom()
		{
			Il2CppClassPointerStore<Geom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "Geom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Geom>.NativeClassPtr);
			Geom.NativeMethodInfoPtr_IsWindingInside_Public_Static_Boolean_WindingRule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665863);
			Geom.NativeMethodInfoPtr_VertCCW_Public_Static_Boolean_Vertex_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665864);
			Geom.NativeMethodInfoPtr_VertEq_Public_Static_Boolean_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665865);
			Geom.NativeMethodInfoPtr_VertLeq_Public_Static_Boolean_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665866);
			Geom.NativeMethodInfoPtr_EdgeEval_Public_Static_Single_Vertex_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665867);
			Geom.NativeMethodInfoPtr_EdgeSign_Public_Static_Single_Vertex_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665868);
			Geom.NativeMethodInfoPtr_TransLeq_Public_Static_Boolean_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665869);
			Geom.NativeMethodInfoPtr_TransEval_Public_Static_Single_Vertex_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665870);
			Geom.NativeMethodInfoPtr_TransSign_Public_Static_Single_Vertex_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665871);
			Geom.NativeMethodInfoPtr_EdgeGoesLeft_Public_Static_Boolean_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665872);
			Geom.NativeMethodInfoPtr_EdgeGoesRight_Public_Static_Boolean_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665873);
			Geom.NativeMethodInfoPtr_VertL1dist_Public_Static_Single_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665874);
			Geom.NativeMethodInfoPtr_AddWinding_Public_Static_Void_Edge_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665875);
			Geom.NativeMethodInfoPtr_Interpolate_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665876);
			Geom.NativeMethodInfoPtr_Swap_Private_Static_Void_byref_Vertex_byref_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665877);
			Geom.NativeMethodInfoPtr_EdgeIntersect_Public_Static_Void_Vertex_Vertex_Vertex_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Geom>.NativeClassPtr, 100665878);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0005F46C File Offset: 0x0005D66C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 623007, RefRangeEnd = 623014, XrefRangeStart = 623007, XrefRangeEnd = 623007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWindingInside(WindingRule rule, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rule;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_IsWindingInside_Public_Static_Boolean_WindingRule_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0005F4B8 File Offset: 0x0005D6B8
		[CallerCount(0)]
		public unsafe static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(w);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_VertCCW_Public_Static_Boolean_Vertex_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0005F520 File Offset: 0x0005D720
		[CallerCount(0)]
		public unsafe static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_VertEq_Public_Static_Boolean_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0005F574 File Offset: 0x0005D774
		[CallerCount(0)]
		public unsafe static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_VertLeq_Public_Static_Boolean_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0005F5C8 File Offset: 0x0005D7C8
		[CallerCount(0)]
		public unsafe static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(w);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_EdgeEval_Public_Static_Single_Vertex_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0005F630 File Offset: 0x0005D830
		[CallerCount(0)]
		public unsafe static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(w);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_EdgeSign_Public_Static_Single_Vertex_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x0005F698 File Offset: 0x0005D898
		[CallerCount(0)]
		public unsafe static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_TransLeq_Public_Static_Boolean_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0005F6EC File Offset: 0x0005D8EC
		[CallerCount(0)]
		public unsafe static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(w);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_TransEval_Public_Static_Single_Vertex_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0005F754 File Offset: 0x0005D954
		[CallerCount(0)]
		public unsafe static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(w);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_TransSign_Public_Static_Single_Vertex_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0005F7BC File Offset: 0x0005D9BC
		[CallerCount(0)]
		public unsafe static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_EdgeGoesLeft_Public_Static_Boolean_Edge_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0005F800 File Offset: 0x0005DA00
		[CallerCount(0)]
		public unsafe static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_EdgeGoesRight_Public_Static_Boolean_Edge_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x0005F844 File Offset: 0x0005DA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623014, XrefRangeEnd = 623017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_VertL1dist_Public_Static_Single_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x0005F898 File Offset: 0x0005DA98
		[CallerCount(0)]
		public unsafe static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eDst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eSrc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_AddWinding_Public_Static_Void_Edge_Edge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
		[CallerCount(0)]
		public unsafe static float Interpolate(float a, float x, float b, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_Interpolate_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0005F948 File Offset: 0x0005DB48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623019, RefRangeEnd = 623020, XrefRangeStart = 623017, XrefRangeEnd = 623019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_Swap_Private_Static_Void_byref_Vertex_byref_Vertex_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			a = ((intPtr5 == 0) ? null : new MeshUtils.Vertex(intPtr5));
			IntPtr intPtr6 = intPtr2;
			b = ((intPtr6 == 0) ? null : new MeshUtils.Vertex(intPtr6));
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0005F9BC File Offset: 0x0005DBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 623048, RefRangeEnd = 623049, XrefRangeStart = 623020, XrefRangeEnd = 623048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Geom.NativeMethodInfoPtr_EdgeIntersect_Public_Static_Void_Vertex_Vertex_Vertex_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0000CEA9 File Offset: 0x0000B0A9
		public Geom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_IsWindingInside_Public_Static_Boolean_WindingRule_Int32_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_VertCCW_Public_Static_Boolean_Vertex_Vertex_Vertex_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_VertEq_Public_Static_Boolean_Vertex_Vertex_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_VertLeq_Public_Static_Boolean_Vertex_Vertex_0;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr_EdgeEval_Public_Static_Single_Vertex_Vertex_Vertex_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr_EdgeSign_Public_Static_Single_Vertex_Vertex_Vertex_0;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr_TransLeq_Public_Static_Boolean_Vertex_Vertex_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_TransEval_Public_Static_Single_Vertex_Vertex_Vertex_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_TransSign_Public_Static_Single_Vertex_Vertex_Vertex_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_EdgeGoesLeft_Public_Static_Boolean_Edge_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_EdgeGoesRight_Public_Static_Boolean_Edge_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_VertL1dist_Public_Static_Single_Vertex_Vertex_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_AddWinding_Public_Static_Void_Edge_Edge_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_Interpolate_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Static_Void_byref_Vertex_byref_Vertex_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_EdgeIntersect_Public_Static_Void_Vertex_Vertex_Vertex_Vertex_Vertex_0;
	}
}
