using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000028C4 File Offset: 0x00000AC4
		// Note: this type is marked as 'beforefieldinit'.
		static IntegratedSubsystem()
		{
			Il2CppClassPointerStore<IntegratedSubsystem<TSubsystemDescriptor>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "IntegratedSubsystem`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSubsystemDescriptor>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedSubsystem<TSubsystemDescriptor>>.NativeClassPtr);
			IntegratedSubsystem<TSubsystemDescriptor>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystem<TSubsystemDescriptor>>.NativeClassPtr, 100663302);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002944 File Offset: 0x00000B44
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegratedSubsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegratedSubsystem<TSubsystemDescriptor>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystem<TSubsystemDescriptor>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020B7 File Offset: 0x000002B7
		public IntegratedSubsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020C0 File Offset: 0x000002C0
		public TSubsystemDescriptor subsystemDescriptor
		{
			get
			{
				return base.m_SubsystemDescriptor.Cast<TSubsystemDescriptor>();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000020CD File Offset: 0x000002CD
		public TSubsystemDescriptor SubsystemDescriptor
		{
			get
			{
				return this.subsystemDescriptor;
			}
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
