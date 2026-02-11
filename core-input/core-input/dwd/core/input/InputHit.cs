using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.input
{
	// Token: 0x02000048 RID: 72
	public sealed class InputHit : ValueType
	{
		// Token: 0x0600021B RID: 539 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		// Note: this type is marked as 'beforefieldinit'.
		static InputHit()
		{
			Il2CppClassPointerStore<InputHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "InputHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputHit>.NativeClassPtr);
			InputHit.NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputHit>.NativeClassPtr, "Camera");
			InputHit.NativeFieldInfoPtr_Hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputHit>.NativeClassPtr, "Hit");
			InputHit.NativeFieldInfoPtr_Transforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputHit>.NativeClassPtr, "Transforms");
			InputHit.NativeMethodInfoPtr__ctor_Public_Void_Camera_RaycastHit_IList_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHit>.NativeClassPtr, 100663569);
			InputHit.NativeMethodInfoPtr_Contains_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHit>.NativeClassPtr, 100663570);
			InputHit.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHit>.NativeClassPtr, 100663571);
			InputHit.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHit>.NativeClassPtr, 100663572);
			InputHit.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputHit_InputHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHit>.NativeClassPtr, 100663573);
			InputHit.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputHit_InputHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHit>.NativeClassPtr, 100663574);
			InputHit.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHit>.NativeClassPtr, 100663575);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120442, XrefRangeEnd = 1120454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputHit(Camera camera, RaycastHit hit, IList<Transform> transforms)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputHit>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transforms);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHit.NativeMethodInfoPtr__ctor_Public_Void_Camera_RaycastHit_IList_1_Transform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000D84C File Offset: 0x0000BA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120454, XrefRangeEnd = 1120461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Transform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHit.NativeMethodInfoPtr_Contains_Public_Boolean_Transform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120461, XrefRangeEnd = 1120471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHit.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120471, XrefRangeEnd = 1120472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(InputHit other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHit.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputHit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000D94C File Offset: 0x0000BB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120472, XrefRangeEnd = 1120473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InputHit a, InputHit b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHit.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputHit_InputHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000D9AC File Offset: 0x0000BBAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1120502, RefRangeEnd = 1120506, XrefRangeStart = 1120473, XrefRangeEnd = 1120502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InputHit a, InputHit b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHit.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputHit_InputHit_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000DA0C File Offset: 0x0000BC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120506, XrefRangeEnd = 1120509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHit.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000033CE File Offset: 0x000015CE
		public InputHit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000033D7 File Offset: 0x000015D7
		public InputHit()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputHit>.NativeClassPtr))
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000DA50 File Offset: 0x0000BC50
		// (set) Token: 0x06000226 RID: 550 RVA: 0x000033E9 File Offset: 0x000015E9
		public unsafe Camera Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputHit.NativeFieldInfoPtr_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputHit.NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000DA80 File Offset: 0x0000BC80
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00003408 File Offset: 0x00001608
		public unsafe RaycastHit Hit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputHit.NativeFieldInfoPtr_Hit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputHit.NativeFieldInfoPtr_Hit)) = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000DAA8 File Offset: 0x0000BCA8
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00003423 File Offset: 0x00001623
		public unsafe IList<Transform> Transforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputHit.NativeFieldInfoPtr_Transforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputHit.NativeFieldInfoPtr_Transforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_Camera;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_Hit;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_Transforms;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_RaycastHit_IList_1_Transform_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Transform_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputHit_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputHit_InputHit_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputHit_InputHit_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
