using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace boardgames.hints
{
	// Token: 0x02000141 RID: 321
	public class IHinter : Il2CppObjectBase
	{
		// Token: 0x06000EC3 RID: 3779 RVA: 0x0004CA78 File Offset: 0x0004AC78
		// Note: this type is marked as 'beforefieldinit'.
		static IHinter()
		{
			Il2CppClassPointerStore<IHinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.hints", "IHinter");
			IHinter.NativeMethodInfoPtr_SetHint_Public_Abstract_Virtual_New_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHinter>.NativeClassPtr, 100665450);
			IHinter.NativeMethodInfoPtr_MatchesLayer_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHinter>.NativeClassPtr, 100665451);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0004CAC8 File Offset: 0x0004ACC8
		[CallerCount(0)]
		public unsafe virtual void SetHint(string flavor, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHinter.NativeMethodInfoPtr_SetHint_Public_Abstract_Virtual_New_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0004CB24 File Offset: 0x0004AD24
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MatchesLayer(int viewLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHinter.NativeMethodInfoPtr_MatchesLayer_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000091EB File Offset: 0x000073EB
		public IHinter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_SetHint_Public_Abstract_Virtual_New_Void_String_Boolean_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_MatchesLayer_Public_Virtual_New_Boolean_Int32_0;
	}
}
