using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Data
{
	// Token: 0x0200006D RID: 109
	[OriginalName("System.Data.dll", "System.Data", "RBTreeError")]
	public enum RBTreeError
	{
		// Token: 0x04000866 RID: 2150
		InvalidPageSize = 1,
		// Token: 0x04000867 RID: 2151
		PagePositionInSlotInUse = 3,
		// Token: 0x04000868 RID: 2152
		NoFreeSlots,
		// Token: 0x04000869 RID: 2153
		InvalidStateinInsert,
		// Token: 0x0400086A RID: 2154
		InvalidNextSizeInDelete = 7,
		// Token: 0x0400086B RID: 2155
		InvalidStateinDelete,
		// Token: 0x0400086C RID: 2156
		InvalidNodeSizeinDelete,
		// Token: 0x0400086D RID: 2157
		InvalidStateinEndDelete,
		// Token: 0x0400086E RID: 2158
		CannotRotateInvalidsuccessorNodeinDelete,
		// Token: 0x0400086F RID: 2159
		IndexOutOFRangeinGetNodeByIndex = 13,
		// Token: 0x04000870 RID: 2160
		RBDeleteFixup,
		// Token: 0x04000871 RID: 2161
		UnsupportedAccessMethod1,
		// Token: 0x04000872 RID: 2162
		UnsupportedAccessMethod2,
		// Token: 0x04000873 RID: 2163
		UnsupportedAccessMethodInNonNillRootSubtree,
		// Token: 0x04000874 RID: 2164
		AttachedNodeWithZerorbTreeNodeId,
		// Token: 0x04000875 RID: 2165
		CompareNodeInDataRowTree,
		// Token: 0x04000876 RID: 2166
		CompareSateliteTreeNodeInDataRowTree,
		// Token: 0x04000877 RID: 2167
		NestedSatelliteTreeEnumerator
	}
}
