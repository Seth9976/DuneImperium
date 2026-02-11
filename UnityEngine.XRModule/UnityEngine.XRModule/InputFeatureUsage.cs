using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000008 RID: 8
	public sealed class InputFeatureUsage : ValueType
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000034B4 File Offset: 0x000016B4
		// Note: this type is marked as 'beforefieldinit'.
		static InputFeatureUsage()
		{
			Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "InputFeatureUsage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr);
			InputFeatureUsage.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, "m_Name");
			InputFeatureUsage.NativeFieldInfoPtr_m_InternalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, "m_InternalType");
			InputFeatureUsage.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, 100663301);
			InputFeatureUsage.NativeMethodInfoPtr_get_internalType_Internal_get_InputFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, 100663302);
			InputFeatureUsage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, 100663303);
			InputFeatureUsage.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputFeatureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, 100663304);
			InputFeatureUsage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, 100663305);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003570 File Offset: 0x00001770
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002275 File Offset: 0x00000475
		public unsafe string name
		{
			[CallerCount(128)]
			[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFeatureUsage.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000035AC File Offset: 0x000017AC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000227F File Offset: 0x0000047F
		public unsafe InputFeatureType internalType
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFeatureUsage.NativeMethodInfoPtr_get_internalType_Internal_get_InputFeatureType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_InternalType = value;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000035F0 File Offset: 0x000017F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258694, XrefRangeEnd = 1258698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFeatureUsage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003644 File Offset: 0x00001844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258698, XrefRangeEnd = 1258699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(InputFeatureUsage other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFeatureUsage.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputFeatureUsage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000369C File Offset: 0x0000189C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258699, XrefRangeEnd = 1258700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFeatureUsage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002220 File Offset: 0x00000420
		public InputFeatureUsage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002229 File Offset: 0x00000429
		public InputFeatureUsage()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr))
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000036E0 File Offset: 0x000018E0
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000223B File Offset: 0x0000043B
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFeatureUsage.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFeatureUsage.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003708 File Offset: 0x00001908
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000225A File Offset: 0x0000045A
		public unsafe InputFeatureType m_InternalType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFeatureUsage.NativeFieldInfoPtr_m_InternalType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFeatureUsage.NativeFieldInfoPtr_m_InternalType)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003730 File Offset: 0x00001930
		public Type type
		{
			get
			{
				Type type;
				switch (this.m_InternalType)
				{
				case InputFeatureType.Custom:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Il2CppStructArray<byte>>());
					break;
				case InputFeatureType.Binary:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
					break;
				case InputFeatureType.DiscreteStates:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>());
					break;
				case InputFeatureType.Axis1D:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
					break;
				case InputFeatureType.Axis2D:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Vector2>());
					break;
				case InputFeatureType.Axis3D:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Vector3>());
					break;
				case InputFeatureType.Rotation:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Quaternion>());
					break;
				case InputFeatureType.Hand:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Hand>());
					break;
				case InputFeatureType.Bone:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Bone>());
					break;
				case InputFeatureType.Eyes:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Eyes>());
					break;
				default:
					throw new InvalidCastException("No valid managed type for unknown native type.");
				}
				return type;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000380C File Offset: 0x00001A0C
		public static bool operator ==(InputFeatureUsage a, InputFeatureUsage b)
		{
			return a.Equals(b);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003828 File Offset: 0x00001A28
		public static bool operator !=(InputFeatureUsage a, InputFeatureUsage b)
		{
			return !(a == b);
		}

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalType;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_get_internalType_Internal_get_InputFeatureType_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputFeatureUsage_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
