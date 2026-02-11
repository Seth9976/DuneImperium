using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000036 RID: 54
	public sealed class InstantiationParameters : ValueType
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x0000FF20 File Offset: 0x0000E120
		// Note: this type is marked as 'beforefieldinit'.
		static InstantiationParameters()
		{
			Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "InstantiationParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr);
			InstantiationParameters.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, "m_Position");
			InstantiationParameters.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, "m_Rotation");
			InstantiationParameters.NativeFieldInfoPtr_m_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, "m_Parent");
			InstantiationParameters.NativeFieldInfoPtr_m_InstantiateInWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, "m_InstantiateInWorldPosition");
			InstantiationParameters.NativeFieldInfoPtr_m_SetPositionRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, "m_SetPositionRotation");
			InstantiationParameters.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, 100663777);
			InstantiationParameters.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, 100663778);
			InstantiationParameters.NativeMethodInfoPtr_get_Parent_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, 100663779);
			InstantiationParameters.NativeMethodInfoPtr_get_InstantiateInWorldPosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, 100663780);
			InstantiationParameters.NativeMethodInfoPtr_get_SetPositionRotation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, 100663781);
			InstantiationParameters.NativeMethodInfoPtr__ctor_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, 100663782);
			InstantiationParameters.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, 100663783);
			InstantiationParameters.NativeMethodInfoPtr_Instantiate_Public_TObject_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr, 100663784);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00010054 File Offset: 0x0000E254
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiationParameters.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00010098 File Offset: 0x0000E298
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiationParameters.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x000100DC File Offset: 0x0000E2DC
		public unsafe Transform Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiationParameters.NativeMethodInfoPtr_get_Parent_Public_get_Transform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00010120 File Offset: 0x0000E320
		public unsafe bool InstantiateInWorldPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiationParameters.NativeMethodInfoPtr_get_InstantiateInWorldPosition_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00010164 File Offset: 0x0000E364
		public unsafe bool SetPositionRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiationParameters.NativeMethodInfoPtr_get_SetPositionRotation_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000101A8 File Offset: 0x0000E3A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1140402, RefRangeEnd = 1140407, XrefRangeStart = 1140397, XrefRangeEnd = 1140402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstantiationParameters(Transform parent, bool instantiateInWorldSpace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantiateInWorldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiationParameters.NativeMethodInfoPtr__ctor_Public_Void_Transform_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00010208 File Offset: 0x0000E408
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1140408, RefRangeEnd = 1140413, XrefRangeStart = 1140407, XrefRangeEnd = 1140408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstantiationParameters(Vector3 position, Quaternion rotation, Transform parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstantiationParameters.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Transform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00010274 File Offset: 0x0000E474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1140431, RefRangeEnd = 1140432, XrefRangeStart = 1140413, XrefRangeEnd = 1140431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TObject Instantiate<TObject>(TObject source) where TObject : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TObject).IsValueType)
				{
					TObject tobject = source;
					intPtr = ((tobject is string) ? IL2CPP.ManagedStringToIl2Cpp(tobject as string) : IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref source;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InstantiationParameters.MethodInfoStoreGeneric_Instantiate_Public_TObject_TObject_0<TObject>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TObject>(intPtr2, false, true);
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000032C6 File Offset: 0x000014C6
		public InstantiationParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000032CF File Offset: 0x000014CF
		public InstantiationParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr))
		{
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000102FC File Offset: 0x0000E4FC
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000032E1 File Offset: 0x000014E1
		public unsafe Vector3 m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiationParameters.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiationParameters.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00010324 File Offset: 0x0000E524
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x000032FC File Offset: 0x000014FC
		public unsafe Quaternion m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiationParameters.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiationParameters.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0001034C File Offset: 0x0000E54C
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00003317 File Offset: 0x00001517
		public unsafe Transform m_Parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiationParameters.NativeFieldInfoPtr_m_Parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiationParameters.NativeFieldInfoPtr_m_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0001037C File Offset: 0x0000E57C
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00003336 File Offset: 0x00001536
		public unsafe bool m_InstantiateInWorldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiationParameters.NativeFieldInfoPtr_m_InstantiateInWorldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiationParameters.NativeFieldInfoPtr_m_InstantiateInWorldPosition)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000103A4 File Offset: 0x0000E5A4
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00003351 File Offset: 0x00001551
		public unsafe bool m_SetPositionRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiationParameters.NativeFieldInfoPtr_m_SetPositionRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstantiationParameters.NativeFieldInfoPtr_m_SetPositionRotation)) = value;
			}
		}

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_m_Parent;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_m_InstantiateInWorldPosition;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_m_SetPositionRotation;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_Transform_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_get_InstantiateInWorldPosition_Public_get_Boolean_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_get_SetPositionRotation_Public_get_Boolean_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_Boolean_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Transform_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_TObject_TObject_0;

		// Token: 0x02000083 RID: 131
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_TObject_TObject_0<TObject>
		{
			// Token: 0x0400049A RID: 1178
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InstantiationParameters.NativeMethodInfoPtr_Instantiate_Public_TObject_TObject_0, Il2CppClassPointerStore<InstantiationParameters>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}
