using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal.LibTessDotNet
{
	// Token: 0x0200010C RID: 268
	public static class MeshUtils : Object
	{
		// Token: 0x06001669 RID: 5737 RVA: 0x000602E4 File Offset: 0x0005E4E4
		// Note: this type is marked as 'beforefieldinit'.
		static MeshUtils()
		{
			Il2CppClassPointerStore<MeshUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.LibTessDotNet", "MeshUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr);
			MeshUtils.NativeFieldInfoPtr_Undef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, "Undef");
			MeshUtils.NativeMethodInfoPtr_MakeEdge_Public_Static_Edge_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100665900);
			MeshUtils.NativeMethodInfoPtr_Splice_Public_Static_Void_Edge_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100665901);
			MeshUtils.NativeMethodInfoPtr_MakeVertex_Public_Static_Void_Edge_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100665902);
			MeshUtils.NativeMethodInfoPtr_MakeFace_Public_Static_Void_Edge_Face_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100665903);
			MeshUtils.NativeMethodInfoPtr_KillEdge_Public_Static_Void_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100665904);
			MeshUtils.NativeMethodInfoPtr_KillVertex_Public_Static_Void_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100665905);
			MeshUtils.NativeMethodInfoPtr_KillFace_Public_Static_Void_Face_Face_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100665906);
			MeshUtils.NativeMethodInfoPtr_FaceArea_Public_Static_Single_Face_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, 100665907);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000603C8 File Offset: 0x0005E5C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 623484, RefRangeEnd = 623489, XrefRangeStart = 623458, XrefRangeEnd = 623484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MeshUtils.Edge MakeEdge(MeshUtils.Edge eNext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eNext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.NativeMethodInfoPtr_MakeEdge_Public_Static_Edge_Edge_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
			}
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0006040C File Offset: 0x0005E60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623489, XrefRangeEnd = 623494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Splice(MeshUtils.Edge a, MeshUtils.Edge b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.NativeMethodInfoPtr_Splice_Public_Static_Void_Edge_Edge_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00060454 File Offset: 0x0005E654
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 623503, RefRangeEnd = 623510, XrefRangeStart = 623494, XrefRangeEnd = 623503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeVertex(MeshUtils.Edge eOrig, MeshUtils.Vertex vNext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eOrig);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vNext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.NativeMethodInfoPtr_MakeVertex_Public_Static_Void_Edge_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0006049C File Offset: 0x0005E69C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 623520, RefRangeEnd = 623525, XrefRangeStart = 623510, XrefRangeEnd = 623520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeFace(MeshUtils.Edge eOrig, MeshUtils.Face fNext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eOrig);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fNext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.NativeMethodInfoPtr_MakeFace_Public_Static_Void_Edge_Face_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x000604E4 File Offset: 0x0005E6E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 623531, RefRangeEnd = 623533, XrefRangeStart = 623525, XrefRangeEnd = 623531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KillEdge(MeshUtils.Edge eDel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eDel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.NativeMethodInfoPtr_KillEdge_Public_Static_Void_Edge_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0006051C File Offset: 0x0005E71C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 623540, RefRangeEnd = 623543, XrefRangeStart = 623533, XrefRangeEnd = 623540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KillVertex(MeshUtils.Vertex vDel, MeshUtils.Vertex newOrg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vDel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newOrg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.NativeMethodInfoPtr_KillVertex_Public_Static_Void_Vertex_Vertex_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00060564 File Offset: 0x0005E764
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 623550, RefRangeEnd = 623554, XrefRangeStart = 623543, XrefRangeEnd = 623550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KillFace(MeshUtils.Face fDel, MeshUtils.Face newLFace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fDel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newLFace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.NativeMethodInfoPtr_KillFace_Public_Static_Void_Face_Face_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x000605AC File Offset: 0x0005E7AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 623554, RefRangeEnd = 623558, XrefRangeStart = 623554, XrefRangeEnd = 623554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float FaceArea(MeshUtils.Face f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.NativeMethodInfoPtr_FaceArea_Public_Static_Single_Face_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0000CF57 File Offset: 0x0000B157
		public MeshUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x000605F0 File Offset: 0x0005E7F0
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x0000CF60 File Offset: 0x0000B160
		public unsafe static int Undef
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MeshUtils.NativeFieldInfoPtr_Undef, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshUtils.NativeFieldInfoPtr_Undef, (void*)(&value));
			}
		}

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeFieldInfoPtr_Undef;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_MakeEdge_Public_Static_Edge_Edge_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_Splice_Public_Static_Void_Edge_Edge_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr_MakeVertex_Public_Static_Void_Edge_Vertex_0;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr_MakeFace_Public_Static_Void_Edge_Face_0;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeMethodInfoPtr_KillEdge_Public_Static_Void_Edge_0;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeMethodInfoPtr_KillVertex_Public_Static_Void_Vertex_Vertex_0;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr_KillFace_Public_Static_Void_Face_Face_0;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeMethodInfoPtr_FaceArea_Public_Static_Single_Face_0;

		// Token: 0x020001D9 RID: 473
		public class Pooled<T> : Object where T : MeshUtils.Pooled<T>, new()
		{
			// Token: 0x06002102 RID: 8450 RVA: 0x000802BC File Offset: 0x0007E4BC
			// Note: this type is marked as 'beforefieldinit'.
			static Pooled()
			{
				Il2CppClassPointerStore<MeshUtils.Pooled<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, "Pooled`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUtils.Pooled<T>>.NativeClassPtr);
				MeshUtils.Pooled<T>.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Pooled<T>>.NativeClassPtr, "_stack");
				MeshUtils.Pooled<T>.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Pooled<T>>.NativeClassPtr, 100665908);
				MeshUtils.Pooled<T>.NativeMethodInfoPtr_OnFree_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Pooled<T>>.NativeClassPtr, 100665909);
				MeshUtils.Pooled<T>.NativeMethodInfoPtr_Create_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Pooled<T>>.NativeClassPtr, 100665910);
				MeshUtils.Pooled<T>.NativeMethodInfoPtr_Free_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Pooled<T>>.NativeClassPtr, 100665911);
				MeshUtils.Pooled<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Pooled<T>>.NativeClassPtr, 100665912);
			}

			// Token: 0x06002103 RID: 8451 RVA: 0x0008039C File Offset: 0x0007E59C
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshUtils.Pooled<T>.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002104 RID: 8452 RVA: 0x000803D8 File Offset: 0x0007E5D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnFree()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshUtils.Pooled<T>.NativeMethodInfoPtr_OnFree_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002105 RID: 8453 RVA: 0x00080414 File Offset: 0x0007E614
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 623330, RefRangeEnd = 623341, XrefRangeStart = 623318, XrefRangeEnd = 623330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static T Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Pooled<T>.NativeMethodInfoPtr_Create_Public_Static_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x06002106 RID: 8454 RVA: 0x00080444 File Offset: 0x0007E644
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 623390, RefRangeEnd = 623400, XrefRangeStart = 623341, XrefRangeEnd = 623390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Free()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Pooled<T>.NativeMethodInfoPtr_Free_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002107 RID: 8455 RVA: 0x00080478 File Offset: 0x0007E678
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pooled()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUtils.Pooled<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Pooled<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002108 RID: 8456 RVA: 0x00012E96 File Offset: 0x00011096
			public Pooled(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BE0 RID: 3040
			// (get) Token: 0x06002109 RID: 8457 RVA: 0x000804B4 File Offset: 0x0007E6B4
			// (set) Token: 0x0600210A RID: 8458 RVA: 0x00012E9F File Offset: 0x0001109F
			public unsafe static Stack<T> _stack
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MeshUtils.Pooled<T>.NativeFieldInfoPtr__stack, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MeshUtils.Pooled<T>.NativeFieldInfoPtr__stack, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001773 RID: 6003
			private static readonly IntPtr NativeFieldInfoPtr__stack;

			// Token: 0x04001774 RID: 6004
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

			// Token: 0x04001775 RID: 6005
			private static readonly IntPtr NativeMethodInfoPtr_OnFree_Public_Virtual_New_Void_0;

			// Token: 0x04001776 RID: 6006
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_T_0;

			// Token: 0x04001777 RID: 6007
			private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Void_0;

			// Token: 0x04001778 RID: 6008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
		}

		// Token: 0x020001DA RID: 474
		public class Vertex : MeshUtils.Pooled<MeshUtils.Vertex>
		{
			// Token: 0x0600210B RID: 8459 RVA: 0x000804DC File Offset: 0x0007E6DC
			// Note: this type is marked as 'beforefieldinit'.
			static Vertex()
			{
				Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, "Vertex");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr);
				MeshUtils.Vertex.NativeFieldInfoPtr__prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, "_prev");
				MeshUtils.Vertex.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, "_next");
				MeshUtils.Vertex.NativeFieldInfoPtr__anEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, "_anEdge");
				MeshUtils.Vertex.NativeFieldInfoPtr__coords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, "_coords");
				MeshUtils.Vertex.NativeFieldInfoPtr__s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, "_s");
				MeshUtils.Vertex.NativeFieldInfoPtr__t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, "_t");
				MeshUtils.Vertex.NativeFieldInfoPtr__pqHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, "_pqHandle");
				MeshUtils.Vertex.NativeFieldInfoPtr__n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, "_n");
				MeshUtils.Vertex.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, "_data");
				MeshUtils.Vertex.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, 100665913);
				MeshUtils.Vertex.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr, 100665914);
			}

			// Token: 0x0600210C RID: 8460 RVA: 0x000805E4 File Offset: 0x0007E7E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623400, XrefRangeEnd = 623408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshUtils.Vertex.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600210D RID: 8461 RVA: 0x00080620 File Offset: 0x0007E820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623408, XrefRangeEnd = 623411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vertex()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUtils.Vertex>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Vertex.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600210E RID: 8462 RVA: 0x00012EB1 File Offset: 0x000110B1
			public Vertex(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BE1 RID: 3041
			// (get) Token: 0x0600210F RID: 8463 RVA: 0x0008065C File Offset: 0x0007E85C
			// (set) Token: 0x06002110 RID: 8464 RVA: 0x00012EBA File Offset: 0x000110BA
			public unsafe MeshUtils.Vertex _prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Vertex>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE2 RID: 3042
			// (get) Token: 0x06002111 RID: 8465 RVA: 0x0008068C File Offset: 0x0007E88C
			// (set) Token: 0x06002112 RID: 8466 RVA: 0x00012ED9 File Offset: 0x000110D9
			public unsafe MeshUtils.Vertex _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Vertex>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE3 RID: 3043
			// (get) Token: 0x06002113 RID: 8467 RVA: 0x000806BC File Offset: 0x0007E8BC
			// (set) Token: 0x06002114 RID: 8468 RVA: 0x00012EF8 File Offset: 0x000110F8
			public unsafe MeshUtils.Edge _anEdge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__anEdge);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__anEdge), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE4 RID: 3044
			// (get) Token: 0x06002115 RID: 8469 RVA: 0x000806EC File Offset: 0x0007E8EC
			// (set) Token: 0x06002116 RID: 8470 RVA: 0x00012F17 File Offset: 0x00011117
			public unsafe Vec3 _coords
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__coords);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__coords)) = value;
				}
			}

			// Token: 0x17000BE5 RID: 3045
			// (get) Token: 0x06002117 RID: 8471 RVA: 0x00080714 File Offset: 0x0007E914
			// (set) Token: 0x06002118 RID: 8472 RVA: 0x00012F32 File Offset: 0x00011132
			public unsafe float _s
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__s);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__s)) = value;
				}
			}

			// Token: 0x17000BE6 RID: 3046
			// (get) Token: 0x06002119 RID: 8473 RVA: 0x0008073C File Offset: 0x0007E93C
			// (set) Token: 0x0600211A RID: 8474 RVA: 0x00012F4D File Offset: 0x0001114D
			public unsafe float _t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__t);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__t)) = value;
				}
			}

			// Token: 0x17000BE7 RID: 3047
			// (get) Token: 0x0600211B RID: 8475 RVA: 0x00080764 File Offset: 0x0007E964
			// (set) Token: 0x0600211C RID: 8476 RVA: 0x00012F68 File Offset: 0x00011168
			public unsafe PQHandle _pqHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__pqHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__pqHandle)) = value;
				}
			}

			// Token: 0x17000BE8 RID: 3048
			// (get) Token: 0x0600211D RID: 8477 RVA: 0x0008078C File Offset: 0x0007E98C
			// (set) Token: 0x0600211E RID: 8478 RVA: 0x00012F83 File Offset: 0x00011183
			public unsafe int _n
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__n);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__n)) = value;
				}
			}

			// Token: 0x17000BE9 RID: 3049
			// (get) Token: 0x0600211F RID: 8479 RVA: 0x000807B4 File Offset: 0x0007E9B4
			// (set) Token: 0x06002120 RID: 8480 RVA: 0x00012F9E File Offset: 0x0001119E
			public unsafe Object _data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Vertex.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001779 RID: 6009
			private static readonly IntPtr NativeFieldInfoPtr__prev;

			// Token: 0x0400177A RID: 6010
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x0400177B RID: 6011
			private static readonly IntPtr NativeFieldInfoPtr__anEdge;

			// Token: 0x0400177C RID: 6012
			private static readonly IntPtr NativeFieldInfoPtr__coords;

			// Token: 0x0400177D RID: 6013
			private static readonly IntPtr NativeFieldInfoPtr__s;

			// Token: 0x0400177E RID: 6014
			private static readonly IntPtr NativeFieldInfoPtr__t;

			// Token: 0x0400177F RID: 6015
			private static readonly IntPtr NativeFieldInfoPtr__pqHandle;

			// Token: 0x04001780 RID: 6016
			private static readonly IntPtr NativeFieldInfoPtr__n;

			// Token: 0x04001781 RID: 6017
			private static readonly IntPtr NativeFieldInfoPtr__data;

			// Token: 0x04001782 RID: 6018
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

			// Token: 0x04001783 RID: 6019
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001DB RID: 475
		public class Face : MeshUtils.Pooled<MeshUtils.Face>
		{
			// Token: 0x06002121 RID: 8481 RVA: 0x000807E4 File Offset: 0x0007E9E4
			// Note: this type is marked as 'beforefieldinit'.
			static Face()
			{
				Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, "Face");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr);
				MeshUtils.Face.NativeFieldInfoPtr__prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr, "_prev");
				MeshUtils.Face.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr, "_next");
				MeshUtils.Face.NativeFieldInfoPtr__anEdge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr, "_anEdge");
				MeshUtils.Face.NativeFieldInfoPtr__trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr, "_trail");
				MeshUtils.Face.NativeFieldInfoPtr__n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr, "_n");
				MeshUtils.Face.NativeFieldInfoPtr__marked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr, "_marked");
				MeshUtils.Face.NativeFieldInfoPtr__inside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr, "_inside");
				MeshUtils.Face.NativeMethodInfoPtr_get_VertsCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr, 100665915);
				MeshUtils.Face.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr, 100665916);
				MeshUtils.Face.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr, 100665917);
			}

			// Token: 0x17000BF1 RID: 3057
			// (get) Token: 0x06002122 RID: 8482 RVA: 0x000808D8 File Offset: 0x0007EAD8
			public unsafe int VertsCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Face.NativeMethodInfoPtr_get_VertsCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002123 RID: 8483 RVA: 0x00080914 File Offset: 0x0007EB14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623411, XrefRangeEnd = 623415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshUtils.Face.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002124 RID: 8484 RVA: 0x00080950 File Offset: 0x0007EB50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623415, XrefRangeEnd = 623418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Face()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUtils.Face>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Face.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002125 RID: 8485 RVA: 0x00012FBD File Offset: 0x000111BD
			public Face(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BEA RID: 3050
			// (get) Token: 0x06002126 RID: 8486 RVA: 0x0008098C File Offset: 0x0007EB8C
			// (set) Token: 0x06002127 RID: 8487 RVA: 0x00012FC6 File Offset: 0x000111C6
			public unsafe MeshUtils.Face _prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Face>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BEB RID: 3051
			// (get) Token: 0x06002128 RID: 8488 RVA: 0x000809BC File Offset: 0x0007EBBC
			// (set) Token: 0x06002129 RID: 8489 RVA: 0x00012FE5 File Offset: 0x000111E5
			public unsafe MeshUtils.Face _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Face>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BEC RID: 3052
			// (get) Token: 0x0600212A RID: 8490 RVA: 0x000809EC File Offset: 0x0007EBEC
			// (set) Token: 0x0600212B RID: 8491 RVA: 0x00013004 File Offset: 0x00011204
			public unsafe MeshUtils.Edge _anEdge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__anEdge);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__anEdge), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BED RID: 3053
			// (get) Token: 0x0600212C RID: 8492 RVA: 0x00080A1C File Offset: 0x0007EC1C
			// (set) Token: 0x0600212D RID: 8493 RVA: 0x00013023 File Offset: 0x00011223
			public unsafe MeshUtils.Face _trail
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__trail);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Face>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__trail), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BEE RID: 3054
			// (get) Token: 0x0600212E RID: 8494 RVA: 0x00080A4C File Offset: 0x0007EC4C
			// (set) Token: 0x0600212F RID: 8495 RVA: 0x00013042 File Offset: 0x00011242
			public unsafe int _n
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__n);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__n)) = value;
				}
			}

			// Token: 0x17000BEF RID: 3055
			// (get) Token: 0x06002130 RID: 8496 RVA: 0x00080A74 File Offset: 0x0007EC74
			// (set) Token: 0x06002131 RID: 8497 RVA: 0x0001305D File Offset: 0x0001125D
			public unsafe bool _marked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__marked);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__marked)) = value;
				}
			}

			// Token: 0x17000BF0 RID: 3056
			// (get) Token: 0x06002132 RID: 8498 RVA: 0x00080A9C File Offset: 0x0007EC9C
			// (set) Token: 0x06002133 RID: 8499 RVA: 0x00013078 File Offset: 0x00011278
			public unsafe bool _inside
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__inside);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Face.NativeFieldInfoPtr__inside)) = value;
				}
			}

			// Token: 0x04001784 RID: 6020
			private static readonly IntPtr NativeFieldInfoPtr__prev;

			// Token: 0x04001785 RID: 6021
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x04001786 RID: 6022
			private static readonly IntPtr NativeFieldInfoPtr__anEdge;

			// Token: 0x04001787 RID: 6023
			private static readonly IntPtr NativeFieldInfoPtr__trail;

			// Token: 0x04001788 RID: 6024
			private static readonly IntPtr NativeFieldInfoPtr__n;

			// Token: 0x04001789 RID: 6025
			private static readonly IntPtr NativeFieldInfoPtr__marked;

			// Token: 0x0400178A RID: 6026
			private static readonly IntPtr NativeFieldInfoPtr__inside;

			// Token: 0x0400178B RID: 6027
			private static readonly IntPtr NativeMethodInfoPtr_get_VertsCount_Internal_get_Int32_0;

			// Token: 0x0400178C RID: 6028
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

			// Token: 0x0400178D RID: 6029
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001DC RID: 476
		public sealed class EdgePair : ValueType
		{
			// Token: 0x06002134 RID: 8500 RVA: 0x00080AC4 File Offset: 0x0007ECC4
			// Note: this type is marked as 'beforefieldinit'.
			static EdgePair()
			{
				Il2CppClassPointerStore<MeshUtils.EdgePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, "EdgePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUtils.EdgePair>.NativeClassPtr);
				MeshUtils.EdgePair.NativeFieldInfoPtr__e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.EdgePair>.NativeClassPtr, "_e");
				MeshUtils.EdgePair.NativeFieldInfoPtr__eSym = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.EdgePair>.NativeClassPtr, "_eSym");
				MeshUtils.EdgePair.NativeMethodInfoPtr_Create_Public_Static_EdgePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.EdgePair>.NativeClassPtr, 100665918);
				MeshUtils.EdgePair.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.EdgePair>.NativeClassPtr, 100665919);
			}

			// Token: 0x06002135 RID: 8501 RVA: 0x00080B40 File Offset: 0x0007ED40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623418, XrefRangeEnd = 623427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static MeshUtils.EdgePair Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.EdgePair.NativeMethodInfoPtr_Create_Public_Static_EdgePair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new MeshUtils.EdgePair(intPtr);
			}

			// Token: 0x06002136 RID: 8502 RVA: 0x00080B6C File Offset: 0x0007ED6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623427, XrefRangeEnd = 623429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.EdgePair.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002137 RID: 8503 RVA: 0x00013093 File Offset: 0x00011293
			public EdgePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002138 RID: 8504 RVA: 0x0001309C File Offset: 0x0001129C
			public EdgePair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUtils.EdgePair>.NativeClassPtr))
			{
			}

			// Token: 0x17000BF2 RID: 3058
			// (get) Token: 0x06002139 RID: 8505 RVA: 0x00080BA4 File Offset: 0x0007EDA4
			// (set) Token: 0x0600213A RID: 8506 RVA: 0x000130AE File Offset: 0x000112AE
			public unsafe MeshUtils.Edge _e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.EdgePair.NativeFieldInfoPtr__e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.EdgePair.NativeFieldInfoPtr__e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF3 RID: 3059
			// (get) Token: 0x0600213B RID: 8507 RVA: 0x00080BD4 File Offset: 0x0007EDD4
			// (set) Token: 0x0600213C RID: 8508 RVA: 0x000130CD File Offset: 0x000112CD
			public unsafe MeshUtils.Edge _eSym
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.EdgePair.NativeFieldInfoPtr__eSym);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.EdgePair.NativeFieldInfoPtr__eSym), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400178E RID: 6030
			private static readonly IntPtr NativeFieldInfoPtr__e;

			// Token: 0x0400178F RID: 6031
			private static readonly IntPtr NativeFieldInfoPtr__eSym;

			// Token: 0x04001790 RID: 6032
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_EdgePair_0;

			// Token: 0x04001791 RID: 6033
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
		}

		// Token: 0x020001DD RID: 477
		public class Edge : MeshUtils.Pooled<MeshUtils.Edge>
		{
			// Token: 0x0600213D RID: 8509 RVA: 0x00080C04 File Offset: 0x0007EE04
			// Note: this type is marked as 'beforefieldinit'.
			static Edge()
			{
				Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshUtils>.NativeClassPtr, "Edge");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr);
				MeshUtils.Edge.NativeFieldInfoPtr__pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, "_pair");
				MeshUtils.Edge.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, "_next");
				MeshUtils.Edge.NativeFieldInfoPtr__Sym = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, "_Sym");
				MeshUtils.Edge.NativeFieldInfoPtr__Onext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, "_Onext");
				MeshUtils.Edge.NativeFieldInfoPtr__Lnext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, "_Lnext");
				MeshUtils.Edge.NativeFieldInfoPtr__Org = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, "_Org");
				MeshUtils.Edge.NativeFieldInfoPtr__Lface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, "_Lface");
				MeshUtils.Edge.NativeFieldInfoPtr__activeRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, "_activeRegion");
				MeshUtils.Edge.NativeFieldInfoPtr__winding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, "_winding");
				MeshUtils.Edge.NativeMethodInfoPtr_get__Rface_Internal_get_Face_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665920);
				MeshUtils.Edge.NativeMethodInfoPtr_set__Rface_Internal_set_Void_Face_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665921);
				MeshUtils.Edge.NativeMethodInfoPtr_get__Dst_Internal_get_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665922);
				MeshUtils.Edge.NativeMethodInfoPtr_set__Dst_Internal_set_Void_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665923);
				MeshUtils.Edge.NativeMethodInfoPtr_get__Oprev_Internal_get_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665924);
				MeshUtils.Edge.NativeMethodInfoPtr_set__Oprev_Internal_set_Void_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665925);
				MeshUtils.Edge.NativeMethodInfoPtr_get__Lprev_Internal_get_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665926);
				MeshUtils.Edge.NativeMethodInfoPtr_set__Lprev_Internal_set_Void_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665927);
				MeshUtils.Edge.NativeMethodInfoPtr_get__Dprev_Internal_get_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665928);
				MeshUtils.Edge.NativeMethodInfoPtr_set__Dprev_Internal_set_Void_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665929);
				MeshUtils.Edge.NativeMethodInfoPtr_get__Rprev_Internal_get_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665930);
				MeshUtils.Edge.NativeMethodInfoPtr_set__Rprev_Internal_set_Void_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665931);
				MeshUtils.Edge.NativeMethodInfoPtr_get__Dnext_Internal_get_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665932);
				MeshUtils.Edge.NativeMethodInfoPtr_set__Dnext_Internal_set_Void_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665933);
				MeshUtils.Edge.NativeMethodInfoPtr_get__Rnext_Internal_get_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665934);
				MeshUtils.Edge.NativeMethodInfoPtr_set__Rnext_Internal_set_Void_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665935);
				MeshUtils.Edge.NativeMethodInfoPtr_EnsureFirst_Internal_Static_Void_byref_Edge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665936);
				MeshUtils.Edge.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665937);
				MeshUtils.Edge.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr, 100665938);
			}

			// Token: 0x17000BFD RID: 3069
			// (get) Token: 0x0600213E RID: 8510 RVA: 0x00080E60 File Offset: 0x0007F060
			// (set) Token: 0x0600213F RID: 8511 RVA: 0x00080EA0 File Offset: 0x0007F0A0
			public unsafe MeshUtils.Face _Rface
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_get__Rface_Internal_get_Face_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Face>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623429, XrefRangeEnd = 623431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_set__Rface_Internal_set_Void_Face_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000BFE RID: 3070
			// (get) Token: 0x06002140 RID: 8512 RVA: 0x00080EE4 File Offset: 0x0007F0E4
			// (set) Token: 0x06002141 RID: 8513 RVA: 0x00080F24 File Offset: 0x0007F124
			public unsafe MeshUtils.Vertex _Dst
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_get__Dst_Internal_get_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Vertex>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623431, XrefRangeEnd = 623433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_set__Dst_Internal_set_Void_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000BFF RID: 3071
			// (get) Token: 0x06002142 RID: 8514 RVA: 0x00080F68 File Offset: 0x0007F168
			// (set) Token: 0x06002143 RID: 8515 RVA: 0x00080FA8 File Offset: 0x0007F1A8
			public unsafe MeshUtils.Edge _Oprev
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_get__Oprev_Internal_get_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623433, XrefRangeEnd = 623435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_set__Oprev_Internal_set_Void_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000C00 RID: 3072
			// (get) Token: 0x06002144 RID: 8516 RVA: 0x00080FEC File Offset: 0x0007F1EC
			// (set) Token: 0x06002145 RID: 8517 RVA: 0x0008102C File Offset: 0x0007F22C
			public unsafe MeshUtils.Edge _Lprev
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_get__Lprev_Internal_get_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623435, XrefRangeEnd = 623437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_set__Lprev_Internal_set_Void_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000C01 RID: 3073
			// (get) Token: 0x06002146 RID: 8518 RVA: 0x00081070 File Offset: 0x0007F270
			// (set) Token: 0x06002147 RID: 8519 RVA: 0x000810B0 File Offset: 0x0007F2B0
			public unsafe MeshUtils.Edge _Dprev
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_get__Dprev_Internal_get_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623437, XrefRangeEnd = 623439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_set__Dprev_Internal_set_Void_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000C02 RID: 3074
			// (get) Token: 0x06002148 RID: 8520 RVA: 0x000810F4 File Offset: 0x0007F2F4
			// (set) Token: 0x06002149 RID: 8521 RVA: 0x00081134 File Offset: 0x0007F334
			public unsafe MeshUtils.Edge _Rprev
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_get__Rprev_Internal_get_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623439, XrefRangeEnd = 623441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_set__Rprev_Internal_set_Void_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000C03 RID: 3075
			// (get) Token: 0x0600214A RID: 8522 RVA: 0x00081178 File Offset: 0x0007F378
			// (set) Token: 0x0600214B RID: 8523 RVA: 0x000811B8 File Offset: 0x0007F3B8
			public unsafe MeshUtils.Edge _Dnext
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_get__Dnext_Internal_get_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623441, XrefRangeEnd = 623443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_set__Dnext_Internal_set_Void_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000C04 RID: 3076
			// (get) Token: 0x0600214C RID: 8524 RVA: 0x000811FC File Offset: 0x0007F3FC
			// (set) Token: 0x0600214D RID: 8525 RVA: 0x0008123C File Offset: 0x0007F43C
			public unsafe MeshUtils.Edge _Rnext
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_get__Rnext_Internal_get_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623443, XrefRangeEnd = 623445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_set__Rnext_Internal_set_Void_Edge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600214E RID: 8526 RVA: 0x00081280 File Offset: 0x0007F480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623445, XrefRangeEnd = 623446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void EnsureFirst(ref MeshUtils.Edge e)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(e);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr_EnsureFirst_Internal_Static_Void_byref_Edge_0, 0, (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					e = ((intPtr4 == 0) ? null : new MeshUtils.Edge(intPtr4));
				}
			}

			// Token: 0x0600214F RID: 8527 RVA: 0x000812CC File Offset: 0x0007F4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623446, XrefRangeEnd = 623455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshUtils.Edge.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002150 RID: 8528 RVA: 0x00081308 File Offset: 0x0007F508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 623455, XrefRangeEnd = 623458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Edge()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUtils.Edge>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUtils.Edge.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002151 RID: 8529 RVA: 0x000130EC File Offset: 0x000112EC
			public Edge(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BF4 RID: 3060
			// (get) Token: 0x06002152 RID: 8530 RVA: 0x00081344 File Offset: 0x0007F544
			// (set) Token: 0x06002153 RID: 8531 RVA: 0x000130F5 File Offset: 0x000112F5
			public MeshUtils.EdgePair _pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__pair);
					return new MeshUtils.EdgePair(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MeshUtils.EdgePair>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__pair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MeshUtils.EdgePair>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000BF5 RID: 3061
			// (get) Token: 0x06002154 RID: 8532 RVA: 0x00081374 File Offset: 0x0007F574
			// (set) Token: 0x06002155 RID: 8533 RVA: 0x00013123 File Offset: 0x00011323
			public unsafe MeshUtils.Edge _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF6 RID: 3062
			// (get) Token: 0x06002156 RID: 8534 RVA: 0x000813A4 File Offset: 0x0007F5A4
			// (set) Token: 0x06002157 RID: 8535 RVA: 0x00013142 File Offset: 0x00011342
			public unsafe MeshUtils.Edge _Sym
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__Sym);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__Sym), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF7 RID: 3063
			// (get) Token: 0x06002158 RID: 8536 RVA: 0x000813D4 File Offset: 0x0007F5D4
			// (set) Token: 0x06002159 RID: 8537 RVA: 0x00013161 File Offset: 0x00011361
			public unsafe MeshUtils.Edge _Onext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__Onext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__Onext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF8 RID: 3064
			// (get) Token: 0x0600215A RID: 8538 RVA: 0x00081404 File Offset: 0x0007F604
			// (set) Token: 0x0600215B RID: 8539 RVA: 0x00013180 File Offset: 0x00011380
			public unsafe MeshUtils.Edge _Lnext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__Lnext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Edge>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__Lnext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BF9 RID: 3065
			// (get) Token: 0x0600215C RID: 8540 RVA: 0x00081434 File Offset: 0x0007F634
			// (set) Token: 0x0600215D RID: 8541 RVA: 0x0001319F File Offset: 0x0001139F
			public unsafe MeshUtils.Vertex _Org
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__Org);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Vertex>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__Org), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BFA RID: 3066
			// (get) Token: 0x0600215E RID: 8542 RVA: 0x00081464 File Offset: 0x0007F664
			// (set) Token: 0x0600215F RID: 8543 RVA: 0x000131BE File Offset: 0x000113BE
			public unsafe MeshUtils.Face _Lface
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__Lface);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshUtils.Face>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__Lface), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BFB RID: 3067
			// (get) Token: 0x06002160 RID: 8544 RVA: 0x00081494 File Offset: 0x0007F694
			// (set) Token: 0x06002161 RID: 8545 RVA: 0x000131DD File Offset: 0x000113DD
			public unsafe Tess.ActiveRegion _activeRegion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__activeRegion);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tess.ActiveRegion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__activeRegion), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BFC RID: 3068
			// (get) Token: 0x06002162 RID: 8546 RVA: 0x000814C4 File Offset: 0x0007F6C4
			// (set) Token: 0x06002163 RID: 8547 RVA: 0x000131FC File Offset: 0x000113FC
			public unsafe int _winding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__winding);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUtils.Edge.NativeFieldInfoPtr__winding)) = value;
				}
			}

			// Token: 0x04001792 RID: 6034
			private static readonly IntPtr NativeFieldInfoPtr__pair;

			// Token: 0x04001793 RID: 6035
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x04001794 RID: 6036
			private static readonly IntPtr NativeFieldInfoPtr__Sym;

			// Token: 0x04001795 RID: 6037
			private static readonly IntPtr NativeFieldInfoPtr__Onext;

			// Token: 0x04001796 RID: 6038
			private static readonly IntPtr NativeFieldInfoPtr__Lnext;

			// Token: 0x04001797 RID: 6039
			private static readonly IntPtr NativeFieldInfoPtr__Org;

			// Token: 0x04001798 RID: 6040
			private static readonly IntPtr NativeFieldInfoPtr__Lface;

			// Token: 0x04001799 RID: 6041
			private static readonly IntPtr NativeFieldInfoPtr__activeRegion;

			// Token: 0x0400179A RID: 6042
			private static readonly IntPtr NativeFieldInfoPtr__winding;

			// Token: 0x0400179B RID: 6043
			private static readonly IntPtr NativeMethodInfoPtr_get__Rface_Internal_get_Face_0;

			// Token: 0x0400179C RID: 6044
			private static readonly IntPtr NativeMethodInfoPtr_set__Rface_Internal_set_Void_Face_0;

			// Token: 0x0400179D RID: 6045
			private static readonly IntPtr NativeMethodInfoPtr_get__Dst_Internal_get_Vertex_0;

			// Token: 0x0400179E RID: 6046
			private static readonly IntPtr NativeMethodInfoPtr_set__Dst_Internal_set_Void_Vertex_0;

			// Token: 0x0400179F RID: 6047
			private static readonly IntPtr NativeMethodInfoPtr_get__Oprev_Internal_get_Edge_0;

			// Token: 0x040017A0 RID: 6048
			private static readonly IntPtr NativeMethodInfoPtr_set__Oprev_Internal_set_Void_Edge_0;

			// Token: 0x040017A1 RID: 6049
			private static readonly IntPtr NativeMethodInfoPtr_get__Lprev_Internal_get_Edge_0;

			// Token: 0x040017A2 RID: 6050
			private static readonly IntPtr NativeMethodInfoPtr_set__Lprev_Internal_set_Void_Edge_0;

			// Token: 0x040017A3 RID: 6051
			private static readonly IntPtr NativeMethodInfoPtr_get__Dprev_Internal_get_Edge_0;

			// Token: 0x040017A4 RID: 6052
			private static readonly IntPtr NativeMethodInfoPtr_set__Dprev_Internal_set_Void_Edge_0;

			// Token: 0x040017A5 RID: 6053
			private static readonly IntPtr NativeMethodInfoPtr_get__Rprev_Internal_get_Edge_0;

			// Token: 0x040017A6 RID: 6054
			private static readonly IntPtr NativeMethodInfoPtr_set__Rprev_Internal_set_Void_Edge_0;

			// Token: 0x040017A7 RID: 6055
			private static readonly IntPtr NativeMethodInfoPtr_get__Dnext_Internal_get_Edge_0;

			// Token: 0x040017A8 RID: 6056
			private static readonly IntPtr NativeMethodInfoPtr_set__Dnext_Internal_set_Void_Edge_0;

			// Token: 0x040017A9 RID: 6057
			private static readonly IntPtr NativeMethodInfoPtr_get__Rnext_Internal_get_Edge_0;

			// Token: 0x040017AA RID: 6058
			private static readonly IntPtr NativeMethodInfoPtr_set__Rnext_Internal_set_Void_Edge_0;

			// Token: 0x040017AB RID: 6059
			private static readonly IntPtr NativeMethodInfoPtr_EnsureFirst_Internal_Static_Void_byref_Edge_0;

			// Token: 0x040017AC RID: 6060
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

			// Token: 0x040017AD RID: 6061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
