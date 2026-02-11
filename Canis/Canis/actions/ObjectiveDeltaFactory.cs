using System;
using Canis.context;
using Canis.tutorialScripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.actions
{
	// Token: 0x020001B7 RID: 439
	public class ObjectiveDeltaFactory : Object
	{
		// Token: 0x060012AA RID: 4778 RVA: 0x00064FCC File Offset: 0x000631CC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectiveDeltaFactory()
		{
			Il2CppClassPointerStore<ObjectiveDeltaFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ObjectiveDeltaFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectiveDeltaFactory>.NativeClassPtr);
			ObjectiveDeltaFactory.NativeMethodInfoPtr_MakeDelta_Public_Abstract_Virtual_New_Int32_Objective_Context_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveDeltaFactory>.NativeClassPtr, 100667296);
			ObjectiveDeltaFactory.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveDeltaFactory>.NativeClassPtr, 100667297);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00065024 File Offset: 0x00063224
		[CallerCount(0)]
		public unsafe virtual int MakeDelta(Objective objective, Context context, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objective);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectiveDeltaFactory.NativeMethodInfoPtr_MakeDelta_Public_Abstract_Virtual_New_Int32_Objective_Context_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x000650A0 File Offset: 0x000632A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectiveDeltaFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectiveDeltaFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectiveDeltaFactory.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00009299 File Offset: 0x00007499
		public ObjectiveDeltaFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_MakeDelta_Public_Abstract_Virtual_New_Int32_Objective_Context_Match_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
