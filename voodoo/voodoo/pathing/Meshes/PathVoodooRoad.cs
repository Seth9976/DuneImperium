using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace voodoo.pathing.Meshes
{
	// Token: 0x02000039 RID: 57
	public class PathVoodooRoad : PathVoodooMesh
	{
		// Token: 0x06000395 RID: 917 RVA: 0x00014B74 File Offset: 0x00012D74
		// Note: this type is marked as 'beforefieldinit'.
		static PathVoodooRoad()
		{
			Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing.Meshes", "PathVoodooRoad");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr);
			PathVoodooRoad.NativeFieldInfoPtr_closeFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, "closeFront");
			PathVoodooRoad.NativeFieldInfoPtr_closeBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, "closeBack");
			PathVoodooRoad.NativeFieldInfoPtr_widthType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, "widthType");
			PathVoodooRoad.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, "width");
			PathVoodooRoad.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, "height");
			PathVoodooRoad.NativeFieldInfoPtr_widthCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, "widthCurve");
			PathVoodooRoad.NativeFieldInfoPtr_frontVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, "frontVertices");
			PathVoodooRoad.NativeFieldInfoPtr_backVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, "backVertices");
			PathVoodooRoad.NativeFieldInfoPtr_frontNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, "frontNormal");
			PathVoodooRoad.NativeFieldInfoPtr_backNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, "backNormal");
			PathVoodooRoad.NativeMethodInfoPtr_InitializeMesh_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, 100663697);
			PathVoodooRoad.NativeMethodInfoPtr_FinalizeMesh_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, 100663698);
			PathVoodooRoad.NativeMethodInfoPtr_GenerateMeshPart_Protected_Virtual_Void_Int32_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, 100663699);
			PathVoodooRoad.NativeMethodInfoPtr_GetNumberOfMaterials_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, 100663700);
			PathVoodooRoad.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr, 100663701);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00014CD0 File Offset: 0x00012ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108739, XrefRangeEnd = 1108751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooRoad.NativeMethodInfoPtr_InitializeMesh_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00014D0C File Offset: 0x00012F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108751, XrefRangeEnd = 1108854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinalizeMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooRoad.NativeMethodInfoPtr_FinalizeMesh_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00014D48 File Offset: 0x00012F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108854, XrefRangeEnd = 1108957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateMeshPart(int piece, Vector3 position, Vector3 direction, Vector3 xd, Vector3 yd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref piece;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xd;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooRoad.NativeMethodInfoPtr_GenerateMeshPart_Protected_Virtual_Void_Int32_Vector3_Vector3_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00014DCC File Offset: 0x00012FCC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNumberOfMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooRoad.NativeMethodInfoPtr_GetNumberOfMaterials_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00014E14 File Offset: 0x00013014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108957, XrefRangeEnd = 1108958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathVoodooRoad()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathVoodooRoad>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooRoad.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00003D61 File Offset: 0x00001F61
		public PathVoodooRoad(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00014E50 File Offset: 0x00013050
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00003D6A File Offset: 0x00001F6A
		public unsafe bool closeFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_closeFront);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_closeFront)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00014E78 File Offset: 0x00013078
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00003D85 File Offset: 0x00001F85
		public unsafe bool closeBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_closeBack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_closeBack)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00014EA0 File Offset: 0x000130A0
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public unsafe PathVoodooRoad.WidthType widthType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_widthType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_widthType)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00014EC8 File Offset: 0x000130C8
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003DBB File Offset: 0x00001FBB
		public unsafe float width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00014EF0 File Offset: 0x000130F0
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00003DD6 File Offset: 0x00001FD6
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00014F18 File Offset: 0x00013118
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00003DF1 File Offset: 0x00001FF1
		public unsafe AnimationCurve widthCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_widthCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_widthCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00014F48 File Offset: 0x00013148
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00003E10 File Offset: 0x00002010
		public unsafe List<int> frontVertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_frontVertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_frontVertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00014F78 File Offset: 0x00013178
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00003E2F File Offset: 0x0000202F
		public unsafe List<int> backVertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_backVertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_backVertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00014FA8 File Offset: 0x000131A8
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00003E4E File Offset: 0x0000204E
		public unsafe Vector3 frontNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_frontNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_frontNormal)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00014FD0 File Offset: 0x000131D0
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00003E69 File Offset: 0x00002069
		public unsafe Vector3 backNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_backNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooRoad.NativeFieldInfoPtr_backNormal)) = value;
			}
		}

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_closeFront;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_closeBack;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_widthType;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_widthCurve;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr_frontVertices;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_backVertices;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr_frontNormal;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr_backNormal;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_InitializeMesh_Protected_Virtual_Void_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeMesh_Protected_Virtual_Void_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMeshPart_Protected_Virtual_Void_Int32_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfMaterials_Protected_Virtual_Int32_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C7 RID: 199
		public enum WidthType
		{
			// Token: 0x04000696 RID: 1686
			Constant,
			// Token: 0x04000697 RID: 1687
			Curve
		}
	}
}
