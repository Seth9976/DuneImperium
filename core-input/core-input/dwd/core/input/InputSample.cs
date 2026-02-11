using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.input
{
	// Token: 0x0200004A RID: 74
	public sealed class InputSample : ValueType
	{
		// Token: 0x0600025A RID: 602 RVA: 0x0000E2F0 File Offset: 0x0000C4F0
		// Note: this type is marked as 'beforefieldinit'.
		static InputSample()
		{
			Il2CppClassPointerStore<InputSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "InputSample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputSample>.NativeClassPtr);
			InputSample.NativeFieldInfoPtr_UnscaledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSample>.NativeClassPtr, "UnscaledTime");
			InputSample.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSample>.NativeClassPtr, "Position");
			InputSample.NativeFieldInfoPtr_Hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSample>.NativeClassPtr, "Hit");
			InputSample.NativeMethodInfoPtr__ctor_Public_Void_Single_Vector2_Nullable_1_InputHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSample>.NativeClassPtr, 100663589);
			InputSample.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSample>.NativeClassPtr, 100663590);
			InputSample.NativeMethodInfoPtr_Contains_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSample>.NativeClassPtr, 100663591);
			InputSample.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSample>.NativeClassPtr, 100663592);
			InputSample.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSample>.NativeClassPtr, 100663593);
			InputSample.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputSample_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSample>.NativeClassPtr, 100663594);
			InputSample.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputSample_InputSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSample>.NativeClassPtr, 100663595);
			InputSample.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSample>.NativeClassPtr, 100663596);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000E3FC File Offset: 0x0000C5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120708, XrefRangeEnd = 1120709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputSample(float unscaledTime, Vector2 position, Nullable<InputHit> hit)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSample>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unscaledTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hit));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSample.NativeMethodInfoPtr__ctor_Public_Void_Single_Vector2_Nullable_1_InputHit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000E470 File Offset: 0x0000C670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120709, XrefRangeEnd = 1120715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSample.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000E4AC File Offset: 0x0000C6AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1120717, RefRangeEnd = 1120721, XrefRangeStart = 1120715, XrefRangeEnd = 1120717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Transform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSample.NativeMethodInfoPtr_Contains_Public_Boolean_Transform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000E500 File Offset: 0x0000C700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120721, XrefRangeEnd = 1120731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSample.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000E554 File Offset: 0x0000C754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120731, XrefRangeEnd = 1120732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(InputSample other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSample.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputSample_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000E5AC File Offset: 0x0000C7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120732, XrefRangeEnd = 1120733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InputSample a, InputSample b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSample.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputSample_InputSample_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000E60C File Offset: 0x0000C80C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1120742, RefRangeEnd = 1120745, XrefRangeStart = 1120733, XrefRangeEnd = 1120742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InputSample a, InputSample b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSample.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputSample_InputSample_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000E66C File Offset: 0x0000C86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120745, XrefRangeEnd = 1120748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputSample.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00003622 File Offset: 0x00001822
		public InputSample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000362B File Offset: 0x0000182B
		public InputSample()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSample>.NativeClassPtr))
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
		// (set) Token: 0x06000266 RID: 614 RVA: 0x0000363D File Offset: 0x0000183D
		public unsafe float UnscaledTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSample.NativeFieldInfoPtr_UnscaledTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSample.NativeFieldInfoPtr_UnscaledTime)) = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000E6D8 File Offset: 0x0000C8D8
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00003658 File Offset: 0x00001858
		public unsafe Vector2 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSample.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSample.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000E700 File Offset: 0x0000C900
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00003673 File Offset: 0x00001873
		public Nullable<InputHit> Hit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSample.NativeFieldInfoPtr_Hit);
				return new Nullable<InputHit>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<InputHit>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputSample.NativeFieldInfoPtr_Hit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<InputHit>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_UnscaledTime;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_Hit;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Vector2_Nullable_1_InputHit_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Transform_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputSample_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputSample_InputSample_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputSample_InputSample_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
