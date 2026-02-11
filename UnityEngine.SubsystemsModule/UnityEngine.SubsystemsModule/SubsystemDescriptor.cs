using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public class SubsystemDescriptor : Object
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002CD4 File Offset: 0x00000ED4
		// Note: this type is marked as 'beforefieldinit'.
		static SubsystemDescriptor()
		{
			Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "SubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr);
			SubsystemDescriptor.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr, "<id>k__BackingField");
			SubsystemDescriptor.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr, 100663309);
			SubsystemDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr, 100663310);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002D40 File Offset: 0x00000F40
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000021F7 File Offset: 0x000003F7
		public unsafe virtual string id
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptor.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this._id_k__BackingField = value;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002D78 File Offset: 0x00000F78
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubsystemDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021CF File Offset: 0x000003CF
		public SubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002DB4 File Offset: 0x00000FB4
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000021D8 File Offset: 0x000003D8
		public unsafe string _id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubsystemDescriptor.NativeFieldInfoPtr__id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubsystemDescriptor.NativeFieldInfoPtr__id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002200 File Offset: 0x00000400
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000220D File Offset: 0x0000040D
		public Type subsystemImplementationType
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000221A File Offset: 0x0000041A
		public ISubsystem UnityEngine.ISubsystemDescriptor.Create()
		{
			return this.CreateImpl();
		}

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
