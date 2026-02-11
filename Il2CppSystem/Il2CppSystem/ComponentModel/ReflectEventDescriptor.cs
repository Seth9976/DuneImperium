using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000125 RID: 293
	public sealed class ReflectEventDescriptor : EventDescriptor
	{
		// Token: 0x06001212 RID: 4626 RVA: 0x00061840 File Offset: 0x0005FA40
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectEventDescriptor()
		{
			Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ReflectEventDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr);
			ReflectEventDescriptor.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, "_type");
			ReflectEventDescriptor.NativeFieldInfoPtr__componentClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, "_componentClass");
			ReflectEventDescriptor.NativeFieldInfoPtr__addMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, "_addMethod");
			ReflectEventDescriptor.NativeFieldInfoPtr__removeMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, "_removeMethod");
			ReflectEventDescriptor.NativeFieldInfoPtr__realEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, "_realEvent");
			ReflectEventDescriptor.NativeFieldInfoPtr__filledMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, "_filledMethods");
			ReflectEventDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, 100665939);
			ReflectEventDescriptor.NativeMethodInfoPtr_FillAttributes_Protected_Virtual_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, 100665940);
			ReflectEventDescriptor.NativeMethodInfoPtr_FillEventInfoAttribute_Private_Void_EventInfo_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, 100665941);
			ReflectEventDescriptor.NativeMethodInfoPtr_FillMethods_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, 100665942);
			ReflectEventDescriptor.NativeMethodInfoPtr_FillSingleMethodAttribute_Private_Void_MethodInfo_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr, 100665943);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0006194C File Offset: 0x0005FB4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 460238, RefRangeEnd = 460239, XrefRangeStart = 460219, XrefRangeEnd = 460238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectEventDescriptor(Type componentClass, EventInfo eventInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectEventDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectEventDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_EventInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000619AC File Offset: 0x0005FBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460239, XrefRangeEnd = 460246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FillAttributes(IList attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectEventDescriptor.NativeMethodInfoPtr_FillAttributes_Protected_Virtual_Void_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000619F0 File Offset: 0x0005FBF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 460275, RefRangeEnd = 460276, XrefRangeStart = 460246, XrefRangeEnd = 460275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(realEventInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectEventDescriptor.NativeMethodInfoPtr_FillEventInfoAttribute_Private_Void_EventInfo_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00061A44 File Offset: 0x0005FC44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 460330, RefRangeEnd = 460331, XrefRangeStart = 460276, XrefRangeEnd = 460330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillMethods()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectEventDescriptor.NativeMethodInfoPtr_FillMethods_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00061A78 File Offset: 0x0005FC78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 460367, RefRangeEnd = 460369, XrefRangeStart = 460331, XrefRangeEnd = 460367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(realMethodInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectEventDescriptor.NativeMethodInfoPtr_FillSingleMethodAttribute_Private_Void_MethodInfo_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00008597 File Offset: 0x00006797
		public ReflectEventDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x00061ACC File Offset: 0x0005FCCC
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x000085A0 File Offset: 0x000067A0
		public unsafe Type _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x00061AFC File Offset: 0x0005FCFC
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x000085BF File Offset: 0x000067BF
		public unsafe Type _componentClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__componentClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__componentClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x00061B2C File Offset: 0x0005FD2C
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x000085DE File Offset: 0x000067DE
		public unsafe MethodInfo _addMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__addMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__addMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x00061B5C File Offset: 0x0005FD5C
		// (set) Token: 0x06001220 RID: 4640 RVA: 0x000085FD File Offset: 0x000067FD
		public unsafe MethodInfo _removeMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__removeMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__removeMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x00061B8C File Offset: 0x0005FD8C
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x0000861C File Offset: 0x0000681C
		public unsafe EventInfo _realEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__realEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__realEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00061BBC File Offset: 0x0005FDBC
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x0000863B File Offset: 0x0000683B
		public unsafe bool _filledMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__filledMethods);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectEventDescriptor.NativeFieldInfoPtr__filledMethods)) = value;
			}
		}

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeFieldInfoPtr__componentClass;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeFieldInfoPtr__addMethod;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeFieldInfoPtr__removeMethod;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeFieldInfoPtr__realEvent;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeFieldInfoPtr__filledMethods;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_EventInfo_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_FillAttributes_Protected_Virtual_Void_IList_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_FillEventInfoAttribute_Private_Void_EventInfo_IList_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_FillMethods_Private_Void_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_FillSingleMethodAttribute_Private_Void_MethodInfo_IList_0;
	}
}
