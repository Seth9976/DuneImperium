using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace voodoo.pathing.Meshes
{
	// Token: 0x0200003A RID: 58
	public class PathVoodooTorus : PathVoodooMesh
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00014FF8 File Offset: 0x000131F8
		// Note: this type is marked as 'beforefieldinit'.
		static PathVoodooTorus()
		{
			Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing.Meshes", "PathVoodooTorus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr);
			PathVoodooTorus.NativeFieldInfoPtr_closeFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "closeFront");
			PathVoodooTorus.NativeFieldInfoPtr_closeBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "closeBack");
			PathVoodooTorus.NativeFieldInfoPtr_radiusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "radiusType");
			PathVoodooTorus.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "radius");
			PathVoodooTorus.NativeFieldInfoPtr_radiusCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "radiusCurve");
			PathVoodooTorus.NativeFieldInfoPtr_angleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "angleOffset");
			PathVoodooTorus.NativeFieldInfoPtr_twist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "twist");
			PathVoodooTorus.NativeFieldInfoPtr_frontVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "frontVertices");
			PathVoodooTorus.NativeFieldInfoPtr_backVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "backVertices");
			PathVoodooTorus.NativeFieldInfoPtr_fTwist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "fTwist");
			PathVoodooTorus.NativeFieldInfoPtr_frontNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "frontNormal");
			PathVoodooTorus.NativeFieldInfoPtr_backNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "backNormal");
			PathVoodooTorus.NativeFieldInfoPtr_frontPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "frontPosition");
			PathVoodooTorus.NativeFieldInfoPtr_backPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, "backPosition");
			PathVoodooTorus.NativeMethodInfoPtr_InitializeMesh_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, 100663702);
			PathVoodooTorus.NativeMethodInfoPtr_FinalizeMesh_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, 100663703);
			PathVoodooTorus.NativeMethodInfoPtr_GenerateMeshPart_Protected_Virtual_Void_Int32_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, 100663704);
			PathVoodooTorus.NativeMethodInfoPtr_GetNumberOfMaterials_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, 100663705);
			PathVoodooTorus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr, 100663706);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000151A4 File Offset: 0x000133A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108958, XrefRangeEnd = 1108970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooTorus.NativeMethodInfoPtr_InitializeMesh_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000151E0 File Offset: 0x000133E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108970, XrefRangeEnd = 1109079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinalizeMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooTorus.NativeMethodInfoPtr_FinalizeMesh_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0001521C File Offset: 0x0001341C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109079, XrefRangeEnd = 1109115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooTorus.NativeMethodInfoPtr_GenerateMeshPart_Protected_Virtual_Void_Int32_Vector3_Vector3_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000152A0 File Offset: 0x000134A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNumberOfMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PathVoodooTorus.NativeMethodInfoPtr_GetNumberOfMaterials_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000152E8 File Offset: 0x000134E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109115, XrefRangeEnd = 1109116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathVoodooTorus()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathVoodooTorus>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooTorus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00003E84 File Offset: 0x00002084
		public PathVoodooTorus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00015324 File Offset: 0x00013524
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00003E8D File Offset: 0x0000208D
		public unsafe bool closeFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_closeFront);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_closeFront)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0001534C File Offset: 0x0001354C
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00003EA8 File Offset: 0x000020A8
		public unsafe bool closeBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_closeBack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_closeBack)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00015374 File Offset: 0x00013574
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00003EC3 File Offset: 0x000020C3
		public unsafe PathVoodooTorus.RadiusType radiusType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_radiusType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_radiusType)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0001539C File Offset: 0x0001359C
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00003EDE File Offset: 0x000020DE
		public unsafe float radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_radius)) = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003BF RID: 959 RVA: 0x000153C4 File Offset: 0x000135C4
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00003EF9 File Offset: 0x000020F9
		public unsafe AnimationCurve radiusCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_radiusCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_radiusCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x000153F4 File Offset: 0x000135F4
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00003F18 File Offset: 0x00002118
		public unsafe float angleOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_angleOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_angleOffset)) = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0001541C File Offset: 0x0001361C
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003F33 File Offset: 0x00002133
		public unsafe float twist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_twist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_twist)) = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00015444 File Offset: 0x00013644
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00003F4E File Offset: 0x0000214E
		public unsafe List<int> frontVertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_frontVertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_frontVertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00015474 File Offset: 0x00013674
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00003F6D File Offset: 0x0000216D
		public unsafe List<int> backVertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_backVertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_backVertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000154A4 File Offset: 0x000136A4
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00003F8C File Offset: 0x0000218C
		public unsafe float fTwist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_fTwist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_fTwist)) = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000154CC File Offset: 0x000136CC
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00003FA7 File Offset: 0x000021A7
		public unsafe Vector3 frontNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_frontNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_frontNormal)) = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003CD RID: 973 RVA: 0x000154F4 File Offset: 0x000136F4
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00003FC2 File Offset: 0x000021C2
		public unsafe Vector3 backNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_backNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_backNormal)) = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0001551C File Offset: 0x0001371C
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00003FDD File Offset: 0x000021DD
		public unsafe Vector3 frontPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_frontPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_frontPosition)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00015544 File Offset: 0x00013744
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00003FF8 File Offset: 0x000021F8
		public unsafe Vector3 backPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_backPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooTorus.NativeFieldInfoPtr_backPosition)) = value;
			}
		}

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_closeFront;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_closeBack;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_radiusType;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_radiusCurve;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_angleOffset;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr_twist;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr_frontVertices;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_backVertices;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_fTwist;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_frontNormal;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_backNormal;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_frontPosition;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_backPosition;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_InitializeMesh_Protected_Virtual_Void_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeMesh_Protected_Virtual_Void_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMeshPart_Protected_Virtual_Void_Int32_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfMaterials_Protected_Virtual_Int32_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C8 RID: 200
		public enum RadiusType
		{
			// Token: 0x04000699 RID: 1689
			Constant,
			// Token: 0x0400069A RID: 1690
			Curve
		}
	}
}
