using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace voodoo.pathing
{
	// Token: 0x02000034 RID: 52
	public class PathVoodooJoint : MonoBehaviour
	{
		// Token: 0x060002DA RID: 730 RVA: 0x0001249C File Offset: 0x0001069C
		// Note: this type is marked as 'beforefieldinit'.
		static PathVoodooJoint()
		{
			Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing", "PathVoodooJoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr);
			PathVoodooJoint.NativeFieldInfoPtr_connectedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, "connectedPath");
			PathVoodooJoint.NativeFieldInfoPtr__rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, "_rb");
			PathVoodooJoint.NativeFieldInfoPtr__tr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, "_tr");
			PathVoodooJoint.NativeFieldInfoPtr_precision1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, "precision1");
			PathVoodooJoint.NativeFieldInfoPtr_precision2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, "precision2");
			PathVoodooJoint.NativeFieldInfoPtr_followPathOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, "followPathOrientation");
			PathVoodooJoint.NativeFieldInfoPtr_motor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, "motor");
			PathVoodooJoint.NativeFieldInfoPtr_motorForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, "motorForce");
			PathVoodooJoint.NativeMethodInfoPtr_get_Precision1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663619);
			PathVoodooJoint.NativeMethodInfoPtr_set_Precision1_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663620);
			PathVoodooJoint.NativeMethodInfoPtr_get_Precision2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663621);
			PathVoodooJoint.NativeMethodInfoPtr_set_Precision2_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663622);
			PathVoodooJoint.NativeMethodInfoPtr_get_FollowPathOrientation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663623);
			PathVoodooJoint.NativeMethodInfoPtr_set_FollowPathOrientation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663624);
			PathVoodooJoint.NativeMethodInfoPtr_get_Motor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663625);
			PathVoodooJoint.NativeMethodInfoPtr_set_Motor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663626);
			PathVoodooJoint.NativeMethodInfoPtr_get_MotorForce_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663627);
			PathVoodooJoint.NativeMethodInfoPtr_set_MotorForce_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663628);
			PathVoodooJoint.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663629);
			PathVoodooJoint.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663630);
			PathVoodooJoint.NativeMethodInfoPtr_computePosAtMinDistance_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663631);
			PathVoodooJoint.NativeMethodInfoPtr_GetPositionForPos_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663632);
			PathVoodooJoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr, 100663633);
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00012698 File Offset: 0x00010898
		// (set) Token: 0x060002DC RID: 732 RVA: 0x000126D4 File Offset: 0x000108D4
		public unsafe int Precision1
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_get_Precision1_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_set_Precision1_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00012714 File Offset: 0x00010914
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00012750 File Offset: 0x00010950
		public unsafe int Precision2
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_get_Precision2_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_set_Precision2_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00012790 File Offset: 0x00010990
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x000127CC File Offset: 0x000109CC
		public unsafe bool FollowPathOrientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_get_FollowPathOrientation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_set_FollowPathOrientation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0001280C File Offset: 0x00010A0C
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00012848 File Offset: 0x00010A48
		public unsafe bool Motor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_get_Motor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_set_Motor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00012888 File Offset: 0x00010A88
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x000128C4 File Offset: 0x00010AC4
		public unsafe int MotorForce
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_get_MotorForce_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_set_MotorForce_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00012904 File Offset: 0x00010B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108256, XrefRangeEnd = 1108264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00012938 File Offset: 0x00010B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108264, XrefRangeEnd = 1108290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001296C File Offset: 0x00010B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1108308, RefRangeEnd = 1108309, XrefRangeStart = 1108290, XrefRangeEnd = 1108308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float computePosAtMinDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_computePosAtMinDistance_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000129A8 File Offset: 0x00010BA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1108319, RefRangeEnd = 1108322, XrefRangeStart = 1108309, XrefRangeEnd = 1108319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPositionForPos(float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr_GetPositionForPos_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000129F4 File Offset: 0x00010BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108322, XrefRangeEnd = 1108323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathVoodooJoint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathVoodooJoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathVoodooJoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000037AA File Offset: 0x000019AA
		public PathVoodooJoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00012A30 File Offset: 0x00010C30
		// (set) Token: 0x060002EC RID: 748 RVA: 0x000037B3 File Offset: 0x000019B3
		public unsafe PathVoodoo connectedPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_connectedPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathVoodoo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_connectedPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00012A60 File Offset: 0x00010C60
		// (set) Token: 0x060002EE RID: 750 RVA: 0x000037D2 File Offset: 0x000019D2
		public unsafe Rigidbody _rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr__rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr__rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00012A90 File Offset: 0x00010C90
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x000037F1 File Offset: 0x000019F1
		public unsafe Transform _tr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr__tr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr__tr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00012AC0 File Offset: 0x00010CC0
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00003810 File Offset: 0x00001A10
		public unsafe int precision1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_precision1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_precision1)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00012AE8 File Offset: 0x00010CE8
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0000382B File Offset: 0x00001A2B
		public unsafe int precision2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_precision2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_precision2)) = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00012B10 File Offset: 0x00010D10
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00003846 File Offset: 0x00001A46
		public unsafe bool followPathOrientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_followPathOrientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_followPathOrientation)) = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00012B38 File Offset: 0x00010D38
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00003861 File Offset: 0x00001A61
		public unsafe bool motor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_motor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_motor)) = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00012B60 File Offset: 0x00010D60
		// (set) Token: 0x060002FA RID: 762 RVA: 0x0000387C File Offset: 0x00001A7C
		public unsafe int motorForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_motorForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathVoodooJoint.NativeFieldInfoPtr_motorForce)) = value;
			}
		}

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_connectedPath;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr__rb;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr__tr;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_precision1;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_precision2;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_followPathOrientation;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_motor;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_motorForce;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_get_Precision1_Public_get_Int32_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_set_Precision1_Public_set_Void_Int32_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_get_Precision2_Public_get_Int32_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_set_Precision2_Public_set_Void_Int32_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_FollowPathOrientation_Public_get_Boolean_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_set_FollowPathOrientation_Public_set_Void_Boolean_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_get_Motor_Public_get_Boolean_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_set_Motor_Public_set_Void_Boolean_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_get_MotorForce_Public_get_Int32_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_set_MotorForce_Public_set_Void_Int32_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_computePosAtMinDistance_Private_Single_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionForPos_Private_Vector3_Single_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
