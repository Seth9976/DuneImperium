using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000177 RID: 375
	[Serializable]
	public class WeakReference : Object
	{
		// Token: 0x06001921 RID: 6433 RVA: 0x0009C2D0 File Offset: 0x0009A4D0
		// Note: this type is marked as 'beforefieldinit'.
		static WeakReference()
		{
			Il2CppClassPointerStore<WeakReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "WeakReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakReference>.NativeClassPtr);
			WeakReference.NativeFieldInfoPtr_isLongReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, "isLongReference");
			WeakReference.NativeFieldInfoPtr_gcHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, "gcHandle");
			WeakReference.NativeMethodInfoPtr_AllocateHandle_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667637);
			WeakReference.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667638);
			WeakReference.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667639);
			WeakReference.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667640);
			WeakReference.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667641);
			WeakReference.NativeMethodInfoPtr_get_IsAlive_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667642);
			WeakReference.NativeMethodInfoPtr_get_Target_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667643);
			WeakReference.NativeMethodInfoPtr_set_Target_Public_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667644);
			WeakReference.NativeMethodInfoPtr_get_TrackResurrection_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667645);
			WeakReference.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667646);
			WeakReference.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakReference>.NativeClassPtr, 100667647);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0009C404 File Offset: 0x0009A604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349951, XrefRangeEnd = 1349952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocateHandle(Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference.NativeMethodInfoPtr_AllocateHandle_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0009C448 File Offset: 0x0009A648
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0009C484 File Offset: 0x0009A684
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1349954, RefRangeEnd = 1349975, XrefRangeStart = 1349952, XrefRangeEnd = 1349954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference(Object target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0009C4D0 File Offset: 0x0009A6D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1349977, RefRangeEnd = 1349980, XrefRangeStart = 1349975, XrefRangeEnd = 1349977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference(Object target, bool trackResurrection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackResurrection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference.NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0009C52C File Offset: 0x0009A72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349980, XrefRangeEnd = 1349994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakReference>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeakReference.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x0009C590 File Offset: 0x0009A790
		public unsafe virtual bool IsAlive
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 536010, RefRangeEnd = 536017, XrefRangeStart = 536010, XrefRangeEnd = 536017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_get_IsAlive_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0009C5D8 File Offset: 0x0009A7D8
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x0009C624 File Offset: 0x0009A824
		public unsafe virtual Object Target
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349994, XrefRangeEnd = 1349996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_get_Target_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349996, XrefRangeEnd = 1349997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_set_Target_Public_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0009C674 File Offset: 0x0009A874
		public unsafe virtual bool TrackResurrection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_get_TrackResurrection_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0009C6BC File Offset: 0x0009A8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349997, XrefRangeEnd = 1350001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0009C6F8 File Offset: 0x0009A8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350001, XrefRangeEnd = 1350010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeakReference.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0000815D File Offset: 0x0000635D
		public WeakReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0009C75C File Offset: 0x0009A95C
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x00008166 File Offset: 0x00006366
		public unsafe bool isLongReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference.NativeFieldInfoPtr_isLongReference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference.NativeFieldInfoPtr_isLongReference)) = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0009C784 File Offset: 0x0009A984
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x00008181 File Offset: 0x00006381
		public unsafe GCHandle gcHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference.NativeFieldInfoPtr_gcHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeakReference.NativeFieldInfoPtr_gcHandle)) = value;
			}
		}

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeFieldInfoPtr_isLongReference;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeFieldInfoPtr_gcHandle;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr_AllocateHandle_Private_Void_Object_0;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Boolean_0;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAlive_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_Virtual_New_get_Object_0;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_Virtual_New_set_Void_Object_0;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeMethodInfoPtr_get_TrackResurrection_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;
	}
}
