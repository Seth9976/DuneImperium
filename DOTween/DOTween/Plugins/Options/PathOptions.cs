using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000030 RID: 48
	public sealed class PathOptions : ValueType
	{
		// Token: 0x06000337 RID: 823 RVA: 0x00016608 File Offset: 0x00014808
		// Note: this type is marked as 'beforefieldinit'.
		static PathOptions()
		{
			Il2CppClassPointerStore<PathOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Plugins.Options", "PathOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathOptions>.NativeClassPtr);
			PathOptions.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "mode");
			PathOptions.NativeFieldInfoPtr_orientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "orientType");
			PathOptions.NativeFieldInfoPtr_lockPositionAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "lockPositionAxis");
			PathOptions.NativeFieldInfoPtr_lockRotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "lockRotationAxis");
			PathOptions.NativeFieldInfoPtr_isClosedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "isClosedPath");
			PathOptions.NativeFieldInfoPtr_lookAtPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "lookAtPosition");
			PathOptions.NativeFieldInfoPtr_lookAtTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "lookAtTransform");
			PathOptions.NativeFieldInfoPtr_lookAhead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "lookAhead");
			PathOptions.NativeFieldInfoPtr_hasCustomForwardDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "hasCustomForwardDirection");
			PathOptions.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "forward");
			PathOptions.NativeFieldInfoPtr_useLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "useLocalPosition");
			PathOptions.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "parent");
			PathOptions.NativeFieldInfoPtr_isRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "isRigidbody");
			PathOptions.NativeFieldInfoPtr_startupRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "startupRot");
			PathOptions.NativeFieldInfoPtr_startupZRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, "startupZRot");
			PathOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathOptions>.NativeClassPtr, 100664084);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00016778 File Offset: 0x00014978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1132479, XrefRangeEnd = 1132487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathOptions.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002D30 File Offset: 0x00000F30
		public PathOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002D39 File Offset: 0x00000F39
		public PathOptions()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathOptions>.NativeClassPtr))
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600033B RID: 827 RVA: 0x000167B0 File Offset: 0x000149B0
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00002D4B File Offset: 0x00000F4B
		public unsafe PathMode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600033D RID: 829 RVA: 0x000167D8 File Offset: 0x000149D8
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00002D66 File Offset: 0x00000F66
		public unsafe OrientType orientType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_orientType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_orientType)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00016800 File Offset: 0x00014A00
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00002D81 File Offset: 0x00000F81
		public unsafe AxisConstraint lockPositionAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lockPositionAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lockPositionAxis)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00016828 File Offset: 0x00014A28
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00002D9C File Offset: 0x00000F9C
		public unsafe AxisConstraint lockRotationAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lockRotationAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lockRotationAxis)) = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00016850 File Offset: 0x00014A50
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00002DB7 File Offset: 0x00000FB7
		public unsafe bool isClosedPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_isClosedPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_isClosedPath)) = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00016878 File Offset: 0x00014A78
		// (set) Token: 0x06000346 RID: 838 RVA: 0x00002DD2 File Offset: 0x00000FD2
		public unsafe Vector3 lookAtPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAtPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAtPosition)) = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000168A0 File Offset: 0x00014AA0
		// (set) Token: 0x06000348 RID: 840 RVA: 0x00002DED File Offset: 0x00000FED
		public unsafe Transform lookAtTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAtTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAtTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000349 RID: 841 RVA: 0x000168D0 File Offset: 0x00014AD0
		// (set) Token: 0x0600034A RID: 842 RVA: 0x00002E0C File Offset: 0x0000100C
		public unsafe float lookAhead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAhead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_lookAhead)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000168F8 File Offset: 0x00014AF8
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00002E27 File Offset: 0x00001027
		public unsafe bool hasCustomForwardDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_hasCustomForwardDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_hasCustomForwardDirection)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00016920 File Offset: 0x00014B20
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00002E42 File Offset: 0x00001042
		public unsafe Quaternion forward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_forward);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_forward)) = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00016948 File Offset: 0x00014B48
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00002E5D File Offset: 0x0000105D
		public unsafe bool useLocalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_useLocalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_useLocalPosition)) = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00016970 File Offset: 0x00014B70
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00002E78 File Offset: 0x00001078
		public unsafe Transform parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000353 RID: 851 RVA: 0x000169A0 File Offset: 0x00014BA0
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00002E97 File Offset: 0x00001097
		public unsafe bool isRigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_isRigidbody);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_isRigidbody)) = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000355 RID: 853 RVA: 0x000169C8 File Offset: 0x00014BC8
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00002EB2 File Offset: 0x000010B2
		public unsafe Quaternion startupRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_startupRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_startupRot)) = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000357 RID: 855 RVA: 0x000169F0 File Offset: 0x00014BF0
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00002ECD File Offset: 0x000010CD
		public unsafe float startupZRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_startupZRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathOptions.NativeFieldInfoPtr_startupZRot)) = value;
			}
		}

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_orientType;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_lockPositionAxis;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_lockRotationAxis;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_isClosedPath;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_lookAtPosition;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_lookAtTransform;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_lookAhead;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_hasCustomForwardDirection;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_forward;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_useLocalPosition;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_isRigidbody;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_startupRot;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_startupZRot;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
	}
}
