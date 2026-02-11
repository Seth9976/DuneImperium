using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace voodoo.pathing
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	public class Waypoint : global::Il2CppSystem.Object
	{
		// Token: 0x06000305 RID: 773 RVA: 0x00012DCC File Offset: 0x00010FCC
		// Note: this type is marked as 'beforefieldinit'.
		static Waypoint()
		{
			Il2CppClassPointerStore<Waypoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.pathing", "Waypoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Waypoint>.NativeClassPtr);
			Waypoint.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "position");
			Waypoint.NativeFieldInfoPtr_DestinationDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "DestinationDelta");
			Waypoint.NativeFieldInfoPtr_PositionCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "PositionCache");
			Waypoint.NativeFieldInfoPtr_DeltaWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "DeltaWeight");
			Waypoint.NativeFieldInfoPtr_scalePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "scalePos");
			Waypoint.NativeFieldInfoPtr_scaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "scaleMultiplier");
			Waypoint.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "rotation");
			Waypoint.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "weight");
			Waypoint.NativeFieldInfoPtr_rotationWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "rotationWeight");
			Waypoint.NativeFieldInfoPtr_lookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "lookAt");
			Waypoint.NativeFieldInfoPtr_inTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "inTangent");
			Waypoint.NativeFieldInfoPtr_outTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "outTangent");
			Waypoint.NativeFieldInfoPtr_symmetricTangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "symmetricTangents");
			Waypoint.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "velocity");
			Waypoint.NativeFieldInfoPtr_inVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "inVariation");
			Waypoint.NativeFieldInfoPtr_outVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "outVariation");
			Waypoint.NativeFieldInfoPtr_reached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "reached");
			Waypoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663638);
			Waypoint.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663639);
			Waypoint.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663640);
			Waypoint.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663641);
			Waypoint.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663642);
			Waypoint.NativeMethodInfoPtr_get_Weight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663643);
			Waypoint.NativeMethodInfoPtr_set_Weight_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663644);
			Waypoint.NativeMethodInfoPtr_get_RotationWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663645);
			Waypoint.NativeMethodInfoPtr_set_RotationWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663646);
			Waypoint.NativeMethodInfoPtr_get_LookAt_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663647);
			Waypoint.NativeMethodInfoPtr_set_LookAt_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663648);
			Waypoint.NativeMethodInfoPtr_get_InTangent_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663649);
			Waypoint.NativeMethodInfoPtr_set_InTangent_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663650);
			Waypoint.NativeMethodInfoPtr_get_OutTangent_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663651);
			Waypoint.NativeMethodInfoPtr_set_OutTangent_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663652);
			Waypoint.NativeMethodInfoPtr_get_SymmetricTangents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663653);
			Waypoint.NativeMethodInfoPtr_set_SymmetricTangents_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663654);
			Waypoint.NativeMethodInfoPtr_get_InVariation_Public_get_VelocityVariation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663655);
			Waypoint.NativeMethodInfoPtr_set_InVariation_Public_set_Void_VelocityVariation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663656);
			Waypoint.NativeMethodInfoPtr_get_OutVariation_Public_get_VelocityVariation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663657);
			Waypoint.NativeMethodInfoPtr_set_OutVariation_Public_set_Void_VelocityVariation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663658);
			Waypoint.NativeMethodInfoPtr_get_Velocity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663659);
			Waypoint.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663660);
			Waypoint.NativeMethodInfoPtr_get_Reached_Public_get_ReachedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663661);
			Waypoint.NativeMethodInfoPtr_set_Reached_Public_set_Void_ReachedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, 100663662);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00013144 File Offset: 0x00011344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108390, XrefRangeEnd = 1108402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Waypoint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Waypoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00013180 File Offset: 0x00011380
		// (set) Token: 0x06000308 RID: 776 RVA: 0x000131BC File Offset: 0x000113BC
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000309 RID: 777 RVA: 0x000131FC File Offset: 0x000113FC
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00013238 File Offset: 0x00011438
		public unsafe Vector3 Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00013278 File Offset: 0x00011478
		// (set) Token: 0x0600030C RID: 780 RVA: 0x000132B4 File Offset: 0x000114B4
		public unsafe Vector3 Weight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_Weight_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_Weight_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000132F4 File Offset: 0x000114F4
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00013330 File Offset: 0x00011530
		public unsafe float RotationWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_RotationWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_RotationWeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00013370 File Offset: 0x00011570
		// (set) Token: 0x06000310 RID: 784 RVA: 0x000133B0 File Offset: 0x000115B0
		public unsafe Transform LookAt
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_LookAt_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_LookAt_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000311 RID: 785 RVA: 0x000133F4 File Offset: 0x000115F4
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00013430 File Offset: 0x00011630
		public unsafe Vector3 InTangent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_InTangent_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_InTangent_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00013470 File Offset: 0x00011670
		// (set) Token: 0x06000314 RID: 788 RVA: 0x000134AC File Offset: 0x000116AC
		public unsafe Vector3 OutTangent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_OutTangent_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_OutTangent_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000315 RID: 789 RVA: 0x000134EC File Offset: 0x000116EC
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00013528 File Offset: 0x00011728
		public unsafe bool SymmetricTangents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_SymmetricTangents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_SymmetricTangents_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00013568 File Offset: 0x00011768
		// (set) Token: 0x06000318 RID: 792 RVA: 0x000135A4 File Offset: 0x000117A4
		public unsafe Waypoint.VelocityVariation InVariation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_InVariation_Public_get_VelocityVariation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_InVariation_Public_set_Void_VelocityVariation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000135E4 File Offset: 0x000117E4
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00013620 File Offset: 0x00011820
		public unsafe Waypoint.VelocityVariation OutVariation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_OutVariation_Public_get_VelocityVariation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_OutVariation_Public_set_Void_VelocityVariation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00013660 File Offset: 0x00011860
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0001369C File Offset: 0x0001189C
		public unsafe float Velocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_Velocity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600031D RID: 797 RVA: 0x000136DC File Offset: 0x000118DC
		// (set) Token: 0x0600031E RID: 798 RVA: 0x0001371C File Offset: 0x0001191C
		public unsafe Waypoint.ReachedEvent Reached
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_get_Reached_Public_get_ReachedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Waypoint.ReachedEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.NativeMethodInfoPtr_set_Reached_Public_set_Void_ReachedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000038D6 File Offset: 0x00001AD6
		public Waypoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00013760 File Offset: 0x00011960
		// (set) Token: 0x06000321 RID: 801 RVA: 0x000038DF File Offset: 0x00001ADF
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00013788 File Offset: 0x00011988
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000038FA File Offset: 0x00001AFA
		public unsafe Vector3 DestinationDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_DestinationDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_DestinationDelta)) = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000137B0 File Offset: 0x000119B0
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00003915 File Offset: 0x00001B15
		public unsafe Vector3 PositionCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_PositionCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_PositionCache)) = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000137D8 File Offset: 0x000119D8
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003930 File Offset: 0x00001B30
		public unsafe Vector3 DeltaWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_DeltaWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_DeltaWeight)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00013800 File Offset: 0x00011A00
		// (set) Token: 0x06000329 RID: 809 RVA: 0x0000394B File Offset: 0x00001B4B
		public unsafe float scalePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_scalePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_scalePos)) = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00013828 File Offset: 0x00011A28
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00003966 File Offset: 0x00001B66
		public unsafe Vector3 scaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_scaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_scaleMultiplier)) = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00013850 File Offset: 0x00011A50
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003981 File Offset: 0x00001B81
		public unsafe Vector3 rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00013878 File Offset: 0x00011A78
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0000399C File Offset: 0x00001B9C
		public unsafe Vector3 weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_weight)) = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000330 RID: 816 RVA: 0x000138A0 File Offset: 0x00011AA0
		// (set) Token: 0x06000331 RID: 817 RVA: 0x000039B7 File Offset: 0x00001BB7
		public unsafe float rotationWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_rotationWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_rotationWeight)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000332 RID: 818 RVA: 0x000138C8 File Offset: 0x00011AC8
		// (set) Token: 0x06000333 RID: 819 RVA: 0x000039D2 File Offset: 0x00001BD2
		public unsafe Transform lookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_lookAt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_lookAt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000334 RID: 820 RVA: 0x000138F8 File Offset: 0x00011AF8
		// (set) Token: 0x06000335 RID: 821 RVA: 0x000039F1 File Offset: 0x00001BF1
		public unsafe Vector3 inTangent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_inTangent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_inTangent)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00013920 File Offset: 0x00011B20
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00003A0C File Offset: 0x00001C0C
		public unsafe Vector3 outTangent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_outTangent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_outTangent)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00013948 File Offset: 0x00011B48
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00003A27 File Offset: 0x00001C27
		public unsafe bool symmetricTangents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_symmetricTangents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_symmetricTangents)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00013970 File Offset: 0x00011B70
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00003A42 File Offset: 0x00001C42
		public unsafe float velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_velocity)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00013998 File Offset: 0x00011B98
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00003A5D File Offset: 0x00001C5D
		public unsafe Waypoint.VelocityVariation inVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_inVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_inVariation)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600033E RID: 830 RVA: 0x000139C0 File Offset: 0x00011BC0
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00003A78 File Offset: 0x00001C78
		public unsafe Waypoint.VelocityVariation outVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_outVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_outVariation)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000340 RID: 832 RVA: 0x000139E8 File Offset: 0x00011BE8
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00003A93 File Offset: 0x00001C93
		public unsafe Waypoint.ReachedEvent reached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_reached);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Waypoint.ReachedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Waypoint.NativeFieldInfoPtr_reached), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_DestinationDelta;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_PositionCache;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_DeltaWeight;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeFieldInfoPtr_scalePos;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeFieldInfoPtr_scaleMultiplier;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeFieldInfoPtr_weight;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeFieldInfoPtr_rotationWeight;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeFieldInfoPtr_lookAt;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeFieldInfoPtr_inTangent;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeFieldInfoPtr_outTangent;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeFieldInfoPtr_symmetricTangents;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeFieldInfoPtr_inVariation;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_outVariation;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeFieldInfoPtr_reached;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_get_Weight_Public_get_Vector3_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_set_Weight_Public_set_Void_Vector3_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationWeight_Public_get_Single_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationWeight_Public_set_Void_Single_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAt_Public_get_Transform_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_set_LookAt_Public_set_Void_Transform_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_get_InTangent_Public_get_Vector3_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_set_InTangent_Public_set_Void_Vector3_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_get_OutTangent_Public_get_Vector3_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_set_OutTangent_Public_set_Void_Vector3_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_get_SymmetricTangents_Public_get_Boolean_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_set_SymmetricTangents_Public_set_Void_Boolean_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_get_InVariation_Public_get_VelocityVariation_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_set_InVariation_Public_set_Void_VelocityVariation_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_get_OutVariation_Public_get_VelocityVariation_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_set_OutVariation_Public_set_Void_VelocityVariation_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Single_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_set_Velocity_Public_set_Void_Single_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_get_Reached_Public_get_ReachedEvent_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_set_Reached_Public_set_Void_ReachedEvent_0;

		// Token: 0x020000C5 RID: 197
		[Serializable]
		public class ReachedEvent : UnityEvent
		{
			// Token: 0x06000A97 RID: 2711 RVA: 0x0000736C File Offset: 0x0000556C
			// Note: this type is marked as 'beforefieldinit'.
			static ReachedEvent()
			{
				Il2CppClassPointerStore<Waypoint.ReachedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Waypoint>.NativeClassPtr, "ReachedEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Waypoint.ReachedEvent>.NativeClassPtr);
				Waypoint.ReachedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Waypoint.ReachedEvent>.NativeClassPtr, 100663663);
			}

			// Token: 0x06000A98 RID: 2712 RVA: 0x0002C1D0 File Offset: 0x0002A3D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReachedEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Waypoint.ReachedEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Waypoint.ReachedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A99 RID: 2713 RVA: 0x000073A0 File Offset: 0x000055A0
			public ReachedEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000690 RID: 1680
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000C6 RID: 198
		public enum VelocityVariation
		{
			// Token: 0x04000692 RID: 1682
			Slow,
			// Token: 0x04000693 RID: 1683
			Medium,
			// Token: 0x04000694 RID: 1684
			Fast
		}
	}
}
